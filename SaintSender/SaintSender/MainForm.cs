using MailKit;
using MimeKit;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private MailRepository mailRepository;
        private readonly DateTime defaultDate = DateTime.Today.AddDays(-7);
        private readonly int defaultMax = 100;
        private readonly FontAwesome.Sharp.IconButton[] emailButtons;

        public MainForm(MailRepository mailRepository)
        {
            InitializeComponent();
            this.mailRepository = mailRepository;
            this.mailRepository.MaxEmails = defaultMax;
            this.mailRepository.DateFrom = defaultDate;
            refreshTimer.Interval = 600000;
            emailButtons = new FontAwesome.Sharp.IconButton[] { btnReply, btnReplyAll, btnFwd, btnMarkUnread, btnStar };
        }

        private ListViewItem SelectedEmail { get { return emailListView.SelectedItems.Count > 0 ? emailListView.SelectedItems[0] : null; } }
        private ListViewItem SelectedFolder { get { return foldersListView.SelectedItems.Count > 0 ? foldersListView.SelectedItems[0] : null; } }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshForm(false);
            //refreshTimer.Start();
        }

        private void RefreshForm(bool loadEmailsOnly, [Optional] IMailFolder folder, [Optional] DateTime dateFrom)
        {
            userLabel.Text = mailRepository.UserData.Email;

            if (SelectedEmail == null)
            {
                foreach (var button in emailButtons)
                {
                    button.Enabled = false;
                }
            }

            if (loadEmailsOnly)
            {
                emailListView.Items.Clear();
                loadProgressBar.Value = 0;
                folderProgressBar.Value = 0;
                emailContentBrowser.Navigate("about:blank");
                LoadEmailList(folder);
            }
            else
            {

                emailListView.Items.Clear();
                foldersListView.Items.Clear();
                emailContentBrowser.Navigate("about:blank");
                loadProgressBar.Value = 0;
                folderProgressBar.Value = 0;
                folderProgressBar.Show();
                LoadFolderList();
                LoadEmailList(folder);
            }
        }

        private async void LoadEmailList([Optional] IMailFolder folder)
        {
            if (maxMailComboBox.SelectedItem != null)
            {
                mailRepository.MaxEmails = int.Parse(maxMailComboBox.SelectedItem.ToString());
            }
            else
            {
                mailRepository.MaxEmails = defaultMax;
            }
            var progress = new Progress<MailInfo>(email => LoadListViewItem(email));
            await Task.Factory.StartNew(() => mailRepository.GetAllMails(progress, folder), TaskCreationOptions.LongRunning);
        }

        private void LoadListViewItem(MailInfo email)
        {
            loadProgressBar.Maximum = mailRepository.MaxEmails;
            emailListView.Items.Add(new ListViewItem(new string[] { email.Message.Subject, email.Message.From.ToString(), email.Message.Date.DateTime.ToString() }) { Tag = email });
            loadProgressBar.Increment(1);
        }

        private async void LoadFolderList()
        {
            var progress = new Progress<FolderInfo>(folder => LoadFolderItem(folder));
            await Task.Factory.StartNew(() => mailRepository.GetAllFolders(progress), TaskCreationOptions.LongRunning);
            folderProgressBar.Hide();
        }

        private void LoadFolderItem(FolderInfo folder)
        {
            folderProgressBar.Maximum = mailRepository.NumOfFolders;
            foldersListView.Items.Add(new ListViewItem(folder.MailFolder.Name + " (" + folder.FolderSize + ")") { ImageIndex = 0, Tag = folder.MailFolder.Name });
            folderProgressBar.Increment(1);
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
            RefreshForm(false);
        }

        private void emailListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedEmail != null)
            {
                if (((MailInfo)SelectedEmail.Tag).Message.HtmlBody == null)
                {
                    emailContentBrowser.DocumentText = ((MailInfo)SelectedEmail.Tag).Message.TextBody;
                }
                else
                {
                    emailContentBrowser.DocumentText = ((MailInfo)SelectedEmail.Tag).Message.HtmlBody;
                }
                foreach (var button in emailButtons)
                {
                    button.Enabled = true;
                }
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshForm(false);
        }

        private void foldersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedFolder != null) RefreshForm(true, mailRepository.GetFolderByName(SelectedFolder.Tag.ToString()).MailFolder);
        }

        private void maxMailComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mailRepository.MaxEmails = int.Parse(maxMailComboBox.SelectedItem.ToString());
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dateComboBox.SelectedItem.ToString().Equals("1 week"))
            {
                mailRepository.DateFrom = DateTime.Today.AddDays(-7);
            }
            else if (dateComboBox.SelectedItem.ToString().Equals("1 month"))
            {
                mailRepository.DateFrom = DateTime.Today.AddDays(-30);
            }
            else if (dateComboBox.SelectedItem.ToString().Equals("1 year"))
            {
                mailRepository.DateFrom = DateTime.Today.AddDays(-365);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewMailForm newMailForm = new NewMailForm(mailRepository.UserData);
            newMailForm.Show();
        }
    }
}
