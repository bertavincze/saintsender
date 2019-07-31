using System;
using System.Windows.Forms;

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
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Email or password field cannot be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rememberCheckBox.Checked) DataService.SerializeLoginData(txtEmail.Text, txtPassword.Text);
                { 
                    MailRepository mailRepository = new MailRepository("imap.gmail.com", 993, true, new UserData(txtEmail.Text, txtPassword.Text));
                    if (mailRepository.IsLoginSuccessfullyAuth())
                    {
                        new MainForm(mailRepository).Show();
                        Hide();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Authentication error - Please double check email and password fields.", "Authentication error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } 
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("Email address")) txtEmail.Clear();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password")) txtPassword.Clear();
        }
    }
}
