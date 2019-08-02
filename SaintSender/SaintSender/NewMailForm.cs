using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class NewMailForm : MetroFramework.Forms.MetroForm
    {
        private MailRepository mailRepository;
        private MetroFramework.Controls.MetroTextBox[] textBoxes;
        private MailInfo originalMail;
        private bool isReply;
        private bool isFwd;

        public NewMailForm(UserData userData, bool isReply, bool isFwd, [Optional] MailInfo originalMail)
        {
            InitializeComponent();
            mailRepository = new MailRepository("smtp.gmail.com", 465, true, userData);
            textBoxes = new MetroFramework.Controls.MetroTextBox[] { txtSubject, txtTo, txtNewMail, txtCc, txtBcc };
            this.originalMail = originalMail;
            this.isReply = isReply;
            this.isFwd = isFwd;
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

            if (isReply)
            {
                if (string.IsNullOrWhiteSpace(txtCc.Text) && string.IsNullOrWhiteSpace(txtBcc.Text))
                {
                    mailRepository.SendMail(RemoveWhiteSpace(txtTo.Text.Split(',')), txtSubject.Text, txtNewMail.Text, new string[] { }, new string[] { }, true, false, originalMail.Message);
                }
                else if (string.IsNullOrWhiteSpace(txtBcc.Text))
                {
                    mailRepository.SendMail(RemoveWhiteSpace(txtTo.Text.Split(',')), txtSubject.Text, txtNewMail.Text, RemoveWhiteSpace(txtCc.Text.Split(',')), new string[] { }, true, false, originalMail.Message);
                }
                else if (string.IsNullOrWhiteSpace(txtCc.Text))
                {
                    mailRepository.SendMail(RemoveWhiteSpace(txtTo.Text.Split(',')), txtSubject.Text, txtNewMail.Text, new string[] { }, RemoveWhiteSpace(txtBcc.Text.Split(',')), true, false, originalMail.Message);
                }
            }
            else if (isFwd)
            {
                if (string.IsNullOrWhiteSpace(txtCc.Text) && string.IsNullOrWhiteSpace(txtBcc.Text))
                {
                    mailRepository.SendMail(RemoveWhiteSpace(txtTo.Text.Split(',')), txtSubject.Text, txtNewMail.Text, new string[] { }, new string[] { }, false, true, originalMail.Message);
                }
                else if (string.IsNullOrWhiteSpace(txtBcc.Text))
                {
                    mailRepository.SendMail(RemoveWhiteSpace(txtTo.Text.Split(',')), txtSubject.Text, txtNewMail.Text, RemoveWhiteSpace(txtCc.Text.Split(',')), new string[] { }, false, true, originalMail.Message);
                }
                else if (string.IsNullOrWhiteSpace(txtCc.Text))
                {
                    mailRepository.SendMail(RemoveWhiteSpace(txtTo.Text.Split(',')), txtSubject.Text, txtNewMail.Text, new string[] { }, RemoveWhiteSpace(txtBcc.Text.Split(',')), false, true, originalMail.Message);
                }
            }
            else
            {
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
            }

            MessageBox.Show("Email sent.", "", MessageBoxButtons.OK);

            foreach (var textBox in textBoxes)
            {
                textBox.Clear();
            }
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

        private void NewMailForm_Load(object sender, EventArgs e)
        {
            if (isReply)
            {
                txtSubject.Text = "Re: " + originalMail.Message.Subject;
                txtNewMail.Focus();

                if (originalMail.Message.From.Count > 1)
                {
                    foreach (var item in originalMail.Message.From)
                    {
                        if (item != originalMail.Message.From[originalMail.Message.From.Count - 1])
                        {
                            txtTo.Text = item.ToString() + ", ";
                        }
                        else
                        {
                            txtTo.Text = item.ToString();
                        }
                    }
                }
                else
                {
                    txtTo.Text = originalMail.Message.From.ToString();
                }
            }
            else if (isFwd)
            {
                txtSubject.Text = "Fwd: " + originalMail.Message.Subject;
                txtTo.Focus();
                txtNewMail.Enabled = false;
            }
        }
    }
}
