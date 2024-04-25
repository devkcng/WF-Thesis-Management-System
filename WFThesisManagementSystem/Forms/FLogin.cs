using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Helper.SearchEngineHelper;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Forms
{
    public partial class FLogin : KryptonForm
    {   
        private ThesisManagementContext _context;
        public FLogin()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.Text = "";
            _context = new ThesisManagementContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FileGenerator fileGenerator = new FileGenerator();
            fileGenerator.Generator();
            UserLoginHelper userLogin = new UserLoginHelper(_context);
            if (userLogin.Login(txtUsername.Text, txtPassword.Text))
            {
                this.Hide();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Check if the reason for closing is the user clicking the close button
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the form closing event
                }
                Application.Exit();
            }
        }
    }
}
