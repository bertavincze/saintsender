using MimeKit;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private MailRepository mailRepository;

        public MainForm(string email, string password)
        {
            InitializeComponent();
            mailRepository = new MailRepository("imap.gmail.com", 993, true, email, password);
            mailRepository.MaxEmails = 100;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var progress = new Progress<MimeMessage>(email => LoadListViewItem(email));
            await Task.Factory.StartNew(() => mailRepository.GetAllMails(progress), TaskCreationOptions.LongRunning);
        }

        private void LoadListViewItem(MimeMessage email)
        {
            loadProgressBar.Maximum = mailRepository.MaxEmails;
            emailListView.Items.Add(new ListViewItem(new string[] { email.Subject, email.From.ToString(), email.Date.DateTime.ToString() }));
            loadProgressBar.Increment(1);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
