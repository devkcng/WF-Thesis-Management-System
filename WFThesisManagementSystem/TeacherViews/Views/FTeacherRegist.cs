using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using WFThesisManagementSystem.DataAccess;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.TeacherViews.TeacherUserControl;
using Control = System.Windows.Forms.Control;

namespace WFThesisManagementSystem.TeacherViews.Views
{
    public partial class FTeacherRegist : Form
    {
        
        List<KeyValuePair<string,string>> students = new List<KeyValuePair<string, string>>();
        public string GroupId { get; set; }
        private readonly DBConnect dbConnect = new DBConnect();
        public FTeacherRegist(string groupid)
        {
            InitializeComponent();
            ucTeacherAcceptRegistAll1.btnClose.Click += Close;
            ucTeacherAcceptRegistAll1.btnAccept.Click += Accept;
            GroupId = groupid  ;
        }
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void List_Load_Registed()
        {
            //DBConnect dBConnect = new DBConnect();
            DataTable dataTable = dbConnect.LoadData("Student");
            ucTeacherAcceptRegistAll1.flpRegistedView.Controls.Clear(); //flpTopicView.Controls.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                if(GroupId == row["group_id"].ToString())
                {
                    ucTeacherAcceptRegisterSingle.NameStudent = row["student_name"].ToString();
                    ucTeacherAcceptRegisterSingle.IdStudent = row["student_id"].ToString();
                    ucTeacherAcceptRegisterSingle.Regist = "Đã đăng ký";
                    ucTeacherAcceptRegistAll1.flpRegistedView.Controls.Add(ucTeacherAcceptRegisterSingle);
                }  
            }
        }
        private void List_Load_Regist()
        {
           // DBConnect dBConnect = new DBConnect();
            DataTable dataTableRegisterQueue = dbConnect.LoadData("RegisterQueue");
            DataTable dataTableStudent = dbConnect.LoadData("Student");
            ucTeacherAcceptRegistAll1.flpRegistView.Controls.Clear();
            for (int i = 0; i < dataTableRegisterQueue.Rows.Count; i++)
            {
                DataRow rowRegisterQueue = dataTableRegisterQueue.Rows[i];
                UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                if (GroupId == rowRegisterQueue["group_id"].ToString() && rowRegisterQueue["accepted"].ToString() == "False")
                {
                    for(int j = 0;j<dataTableStudent.Rows.Count;j++)
                    {
                        DataRow rowStudent = dataTableStudent.Rows[j];
                        if (rowStudent["student_id"].ToString() == rowRegisterQueue["student_id"].ToString())
                        {
                            ucTeacherAcceptRegisterSingle.NameStudent = rowStudent["student_name"].ToString();
                            ucTeacherAcceptRegisterSingle.IdStudent = rowStudent["student_id"].ToString();
                            ucTeacherAcceptRegisterSingle.Regist = "Đang chờ đăng ký";
                            ucTeacherAcceptRegistAll1.flpRegistView.Controls.Add(ucTeacherAcceptRegisterSingle);
                        }
                    }    
                   
                }
            }
        }
        private void Accept(object sender, EventArgs e)
        {
            //DBConnect dBConnect = new DBConnect();
            DataTable dataTable = dbConnect.LoadData("RegisterQueue");
            for (int i = 0; i < ucTeacherAcceptRegistAll1.flpRegistView.Controls.Count; i++)
            {
                bool check = false;
                string id ="";
                string name ="";
                foreach (Control c in ucTeacherAcceptRegistAll1.flpRegistView.Controls[i].Controls)
                {
                    
                    if(c is CheckBox )
                    {
                        CheckBox select = (CheckBox)c;
                        if(select.Checked)
                        {
                            check = true;
                        }    
                    }
                    if(c is Label && c.Name == "lblIdStudent" && check == true) id = c.Text;
                    if(c is Label && c.Name=="lblNameStudent" && check == true) name = c.Text;
                }
                if(check == true)
                {
                    KeyValuePair<string, string> single_student = new KeyValuePair<string, string>(id,name);
                    for (int j = 0; j < dataTable.Rows.Count; j++)
                    {
                        DataRow row = dataTable.Rows[j];
                        if (row["student_id"].ToString() == id)
                        {
                            if (dbConnect.ExecuteSqlQuery(RegistDAO.UpdateAccept(id)))
                            {
                                ucTeacherAcceptRegistAll1.flpRegistView.Controls[i].Visible = false;
                            }
                            // dataTable.Rows[j]["accept"] = "0"; // đang fix
                        }
                    }
                    students.Add(single_student);
                }    
                
            }
            for (int i = 0; i < students.Count; i++)
            {
              
                UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                ucTeacherAcceptRegisterSingle.NameStudent = students[i].Value;
                ucTeacherAcceptRegisterSingle.IdStudent =  students[i].Key;
                ucTeacherAcceptRegisterSingle.Regist = "Đã đăng ký";
                dbConnect.ExecuteSqlQuery(RegistDAO.UpdateGroupid(students[i].Key, GroupId));
                ucTeacherAcceptRegistAll1.flpRegistedView.Controls.Add(ucTeacherAcceptRegisterSingle); 
            }

        }

        private void FTeacherRegist_Load(object sender, EventArgs e)
        {
            List_Load_Regist();
            List_Load_Registed();
        }
    }
}
