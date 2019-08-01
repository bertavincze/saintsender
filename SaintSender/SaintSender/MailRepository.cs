using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SaintSender
{
    public class MailRepository
    {
        private readonly string mailServer;
        private readonly int port;
        private readonly bool ssl;

        public MailRepository(string mailServer, int port, bool ssl, UserData userData)
        {
            this.mailServer = mailServer;
            this.port = port;
            this.ssl = ssl;
            UserData = userData;
        }

        public int MaxEmails { get; set; }
        public int NumOfFolders { get; private set; }
        public DateTime DateFrom { get; set; }
        public UserData UserData { get; }

        public void GetAllMails(IProgress<MailInfo> progress, [Optional] IMailFolder folder)
        {
            using (ImapClient client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(UserData.Email, UserData.Password);

                if (folder == null) { folder = client.Inbox; }
                else
                {
                    folder = client.GetFolder(folder.FullName);
                }

                folder.Open(FolderAccess.ReadOnly);
                SearchResults results = folder.Search(SearchOptions.All, SearchQuery.DeliveredAfter(DateFrom));

                if (results.UniqueIds.Count < MaxEmails) MaxEmails = results.UniqueIds.Count;

                for (int i = MaxEmails - 1; i >= 0; i--)
                {
                    MailInfo message = new MailInfo(folder.GetMessage(results.UniqueIds[i]), results.UniqueIds[i], folder);
                    progress.Report(message);
                }

                folder.Close();
                client.Disconnect(true);
            }
        }

        public void GetAllFolders(IProgress<FolderInfo> progress)
        {
            using (ImapClient client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(UserData.Email, UserData.Password);

                var folders = client.GetFolders(new FolderNamespace('/', ""));
                NumOfFolders = folders.Count;

                foreach (var folder in folders)
                {
                    try
                    {
                        folder.Open(FolderAccess.ReadOnly);
                        FolderInfo folderInfo = new FolderInfo(folder, 0);
                        var emails = folder.Search(SearchQuery.All);

                        foreach (var email in emails)
                        {
                            folderInfo.FolderSize++;
                        }

                        folder.Close();
                        progress.Report(folderInfo);
                    }
                    catch (ImapCommandException)
                    {
                        continue;
                    }
                }
                client.Disconnect(true);
            }
        }

        public MailInfo GetMailById(MailInfo mailInfo)
        {
            using (ImapClient client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(UserData.Email, UserData.Password);

                IMailFolder folder = client.GetFolder(mailInfo.ParentFolder.FullName);
                folder.Open(FolderAccess.ReadOnly);
                var results = folder.Search(SearchQuery.Uids(new List<UniqueId> { mailInfo.Uid }));

                MailInfo message = new MailInfo(folder.GetMessage(results[0]), results[0], folder);

                client.Disconnect(true);
                return message;
            }
        }

        public FolderInfo GetFolderByName(string name)
        {
            using (ImapClient client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(UserData.Email, UserData.Password);

                var folders = client.GetFolders(new FolderNamespace('/', ""));
                foreach (var folder in folders)
                {
                    if (folder.Name.Equals(name))
                    {
                        FolderInfo folderInfo = new FolderInfo(folder, folder.Count);
                        return folderInfo;
                    }
                }
                client.Disconnect(true);
                return null;
            }
        }

        public void SendMail(string[] emailTo, string subject, string body, [Optional] string[] cc, [Optional] string[] bcc)
        {
            using (SmtpClient client = new SmtpClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(UserData.Email, UserData.Password);

                var message = new MimeMessage();

                foreach (var address in emailTo)
                {
                    message.To.Add(new MailboxAddress(address));
                }

                if (cc != null)
                {
                    foreach (var copy in cc)
                    {
                        message.Cc.Add(new MailboxAddress(copy));
                    }
                }

                if (bcc != null)
                {
                    foreach (var secretCopy in bcc)
                    {
                        message.Bcc.Add(new MailboxAddress(secretCopy));
                    }
                }
                
                message.From.Add(new MailboxAddress(UserData.Email));
                message.Subject = subject;

                message.Body = new TextPart("plain") { Text = body };

                client.Send(message);

                client.Disconnect(true);
            }
        }

        public bool IsLoginSuccessfullyAuth()
        {
            using (ImapClient client = new ImapClient())
            {
                try
                {
                    client.Connect(mailServer, port, ssl);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(UserData.Email, UserData.Password);
                    return true;
                }
                catch (AuthenticationException)
                {
                    return false;
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }
    }
}
