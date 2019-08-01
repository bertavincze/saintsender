using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class NewMailForm : MetroFramework.Forms.MetroForm
    {
        private MailRepository mailRepository;

        public NewMailForm(UserData userData)
        {
            InitializeComponent();
            mailRepository = new MailRepository("smtp.gmail.com", 587, false, userData);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string[] textFields = new string[] { txtSubject.Text, txtTo.Text, txtNewMail.Text };
            foreach (var field in textFields)
            {
                if (string.IsNullOrWhiteSpace(field))
                {
                    MessageBox.Show("One or more required field empty! Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtCc.Text) && string.IsNullOrWhiteSpace(txtBcc.Text))
            {
                mailRepository.SendMail(RemoveWhiteSpace(txtTo.Text.Split(',')), txtSubject.Text, txtNewMail.Text);
            }
            else if (string.IsNullOrWhiteSpace(txtBcc.Text))
            {
                mailRepository.SendMail(RemoveWhiteSpace(txtTo.Text.Split(',')), txtSubject.Text, txtNewMail.Text, RemoveWhiteSpace(txtCc.Text.Split(',')));
            }
            else if (string.IsNullOrWhiteSpace(txtCc.Text))
            {
                mailRepository.SendMail(RemoveWhiteSpace(txtTo.Text.Split(',')), txtSubject.Text, txtNewMail.Text, new string[] { }, RemoveWhiteSpace(txtBcc.Text.Split(',')));
            }

            MessageBox.Show("Email sent.", "Success", MessageBoxButtons.OK);
        }

        private string[] RemoveWhiteSpace(string[] originalArray)
        {
            List<string> temp = new List<string>();
            foreach (var item in originalArray)
            {
                temp.Add(item.Trim());
            }

            return temp.ToArray();
        }
    }
}
