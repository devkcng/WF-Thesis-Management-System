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

        public FTeacherRegist()
        {
            InitializeComponent();
            ucTeacherAcceptRegistAll1.btnClose.Click += Close;
            ucTeacherAcceptRegistAll1.btnAccept.Click += Accept;
        }
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void List_Load_Regist()
        {

            DBConnect dBConnect = new DBConnect();
            DataTable dataTable = dBConnect.LoadData("Student");
            ucTeacherAcceptRegistAll1.flpRegistView.Controls.Clear();  //flpTopicView.Controls.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                ucTeacherAcceptRegisterSingle.NameStudent = row["student_name"].ToString();
                ucTeacherAcceptRegisterSingle.IdStudent = row["student_id"].ToString();
                ucTeacherAcceptRegisterSingle.Regist = "Đang chờ đăng ký";
                ucTeacherAcceptRegistAll1.flpRegistView.Controls.Add(ucTeacherAcceptRegisterSingle);
            }
        }
        private void Accept(object sender, EventArgs e)
        {
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
                    ucTeacherAcceptRegistAll1.flpRegistView.Controls[i].Visible = false;
                    students.Add(single_student);
                }    
                
            }
            ucTeacherAcceptRegistAll1.flpRegisedView.Controls.Clear();  
            for (int i = 0; i < students.Count; i++)
            {
              
                UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                ucTeacherAcceptRegisterSingle.NameStudent = students[i].Key;
                ucTeacherAcceptRegisterSingle.IdStudent = students[i].Value;
                ucTeacherAcceptRegisterSingle.Regist = "Đã đăng ký";
                ucTeacherAcceptRegistAll1.flpRegisedView.Controls.Add(ucTeacherAcceptRegisterSingle); 
                
            }

        }

        private void FTeacherRegist_Load(object sender, EventArgs e)
        {
            List_Load_Regist();
            ucTeacherAcceptRegistAll1.flpRegisedView.Controls.Clear();
        }
    }
}
