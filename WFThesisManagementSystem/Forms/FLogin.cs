using ComponentFactory.Krypton.Toolkit;
using System;
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
    }
}
