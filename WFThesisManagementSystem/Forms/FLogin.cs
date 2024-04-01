using ComponentFactory.Krypton.Toolkit;
using System;
using WFThesisManagementSystem.Helper;
using WFThesisManagementSystem.Helper.SearchEngineHelper;

namespace WFThesisManagementSystem.Forms
{
    public partial class FLogin : KryptonForm
    {
        public FLogin()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FileGenerator fileGenerator = new FileGenerator();
            fileGenerator.Generator();
            UserLoginHelper userLogin = new UserLoginHelper();
            if (userLogin.Login(txtUsername.Text, txtPassword.Text))
            {
                this.Hide();
            }
        }
    }
}
