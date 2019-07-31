using MailKit;
using MimeKit;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private MailRepository mailRepository;

        public MainForm(MailRepository mailRepository)
        {
            InitializeComponent();
            this.mailRepository = mailRepository;
            this.mailRepository.MaxEmails = 100;
        }

        private ListViewItem SelectedEmail { get { return emailListView.SelectedItems.Count > 0 ? emailListView.SelectedItems[0] : null; } }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private async void RefreshForm()
        {
            userLabel.Text = mailRepository.UserData.Email;

            emailListView.Items.Clear();
            foldersListView.Items.Clear();
            emailContentBrowser.ResetText();
            loadProgressBar.Value = 0;

            LoadFolderList();

            var progress = new Progress<MimeMessage>(email => LoadListViewItem(email));
            await Task.Factory.StartNew(() => mailRepository.GetAllMails(progress), TaskCreationOptions.LongRunning);
        }

        private void LoadListViewItem(MimeMessage email)
        {
            loadProgressBar.Maximum = mailRepository.MaxEmails;
            ListViewItem item = new ListViewItem(new string[] { email.Subject, email.From.ToString(), email.Date.DateTime.ToString() });
            item.Tag = email.MessageId;
            emailListView.Items.Add(item);
            loadProgressBar.Increment(1);
        }

        private async void LoadFolderList()
        {
            var progress = new Progress<IMailFolder>(folder => foldersListView.Items.Add(new ListViewItem(folder.Name + " (" + folder.Unread + ")")));
            await Task.Factory.StartNew(() => mailRepository.GetAllFolders(progress), TaskCreationOptions.LongRunning);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Hide();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void emailListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedEmail != null) emailContentBrowser.DocumentText = mailRepository.GetMailById(SelectedEmail.Tag.ToString()).HtmlBody;
        }
    }
}
