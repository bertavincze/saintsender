using System;

namespace SaintSender
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            new MainForm(txtEmail.Text, txtPassword.Text).Show();
            Hide();
        }
    }
}
