using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using WFThesisManagementSystem.Forms.TeacherViews.TeacherUserControl;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;
using Control = System.Windows.Forms.Control;

namespace WFThesisManagementSystem.Forms.TeacherViews.Views
{
    public partial class FTeacherRegist : Form
    {

        List<KeyValuePair<int, string>> students = new List<KeyValuePair<int, string>>();

        StudentRepository _studentRepository;
        RegisterQueueRepository _registerQueueRepository;
        public int GroupId { get; set; }
        public FTeacherRegist(StudentGroup studentGroup)
        {
            InitializeComponent();
            ucTeacherAcceptRegistAll1.btnClose.Click += Close;
            ucTeacherAcceptRegistAll1.btnAccept.Click += Accept;
            ucTeacherAcceptRegistAll1.btnDelete.Click += Delete;
            GroupId = studentGroup.group_id;
            var _context = new ThesisManagementContext();
            _studentRepository = new StudentRepository(_context);
            _registerQueueRepository = new RegisterQueueRepository(_context);
        }
        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
        private void List_Load_Registed()
        {
            ucTeacherAcceptRegistAll1.flpRegistedView.Controls.Clear();
            var Table = _studentRepository.GetAll().Where(x => x.group_id == GroupId);
            foreach (var student in Table)
            {
                UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                ucTeacherAcceptRegisterSingle.NameStudent = student.student_name;
                ucTeacherAcceptRegisterSingle.IdStudent = Convert.ToString(student.student_id);
                ucTeacherAcceptRegisterSingle.Regist = "Registered";
                ucTeacherAcceptRegisterSingle.cbxRegist.Visible = false;
                ucTeacherAcceptRegistAll1.flpRegistedView.Controls.Add(ucTeacherAcceptRegisterSingle);
            }

        }
        private void List_Load_Regist()
        {
            ucTeacherAcceptRegistAll1.flpRegistView.Controls.Clear();
            var Table = _registerQueueRepository.GetAll().Where(x => x.group_id == GroupId && x.accepted == false);
            foreach (var register in Table)
            {
                UcTeacherAcceptRegisterSingle ucTeacherAcceptRegisterSingle = new UcTeacherAcceptRegisterSingle();
                var students = _studentRepository.GetAll().Where(x => x.student_id == register.student_id);
                foreach (var student in students)
                {
                    ucTeacherAcceptRegisterSingle.NameStudent = student.student_name;
                    ucTeacherAcceptRegisterSingle.IdStudent = Convert.ToString(student.student_id);
                    ucTeacherAcceptRegisterSingle.Regist = "Awaiting Registration";
                    ucTeacherAcceptRegistAll1.flpRegistView.Controls.Add(ucTeacherAcceptRegisterSingle);
                }
            }

        }

        private void Accept(object sender, EventArgs e)
        {
            for (int i = 0; i < ucTeacherAcceptRegistAll1.flpRegistView.Controls.Count; i++)
            {
                bool check = false;
                int id = 0;
                string name = "";
                foreach (Control c in ucTeacherAcceptRegistAll1.flpRegistView.Controls[i].Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox select = (CheckBox)c;
                        if (select.Checked)
                        {
                            check = true;
                        }
                    }
                    if (c is Label && c.Name == "lblIdStudent" && check == true) id = int.Parse(c.Text);
                    if (c is Label && c.Name == "lblNameStudent" && check == true) name = c.Text;

                }


                if (check == true)
                {
                    KeyValuePair<int, string> single_student = new KeyValuePair<int, string>(id, name);



                    //ucTeacherAcceptRegistAll1.flpRegistView.Controls[i].Visible = false;


                    var register = _registerQueueRepository.GetById(id);
                    var student = _studentRepository.GetById(id);

                    register.accepted = true;
                    student.group_id = GroupId;

                    _registerQueueRepository.Update(register);
                    _studentRepository.Update(student);

                    students.Add(single_student);
                }

            }

            FTeacherRegist_Load(sender, e);
        }
        private void Delete(object sender, EventArgs e)
        {
            //DataTable dataTable = dbConnect.LoadData("RegisterQueue");
            for (int i = 0; i < ucTeacherAcceptRegistAll1.flpRegistView.Controls.Count; i++)
            {
                bool check = false;
                int id = 0;
                foreach (Control c in ucTeacherAcceptRegistAll1.flpRegistView.Controls[i].Controls)
                {

                    if (c is CheckBox)
                    {
                        CheckBox select = (CheckBox)c;
                        if (select.Checked)
                        {
                            check = true;
                        }
                    }
                    if (c is Label && c.Name == "lblIdStudent" && check == true) id = int.Parse(c.Text);
                }
                if (check == true)
                {

                    // delete row in RegisterQueue

                    var register = _registerQueueRepository.GetById(id);

                    _registerQueueRepository.Delete(register);

                    //ucTeacherAcceptRegistAll1.flpRegistView.Controls[i].Visible = false;
                }
            }
        }

        private void FTeacherRegist_Load(object sender, EventArgs e)
        {
            List_Load_Regist();
            List_Load_Registed();
        }

    }
}
