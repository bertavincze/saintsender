using MailKit;
using MailKit.Net.Imap;
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
        public UserData UserData { get; }

        public void GetAllMails(IProgress<MimeMessage> progress, [Optional] DateTime dateFrom)
        {
            if (dateFrom == new DateTime(0001, 01, 01, 0, 0, 0)) dateFrom = DateTime.Today.AddDays(-7);

            using (ImapClient client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(UserData.Email, UserData.Password);

                IMailFolder inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                SearchResults results = inbox.Search(SearchOptions.All, SearchQuery.DeliveredAfter(dateFrom));

                if (results.UniqueIds.Count < MaxEmails) MaxEmails = results.UniqueIds.Count;

                for (int i = MaxEmails - 1; i >= 0; i--)
                {
                    MimeMessage message = inbox.GetMessage(results.UniqueIds[i]);
                    progress.Report(message);
                }

                client.Disconnect(true);
            }
        }

        public void GetAllFolders(IProgress<IMailFolder> progress)
        {
            using (ImapClient client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(UserData.Email, UserData.Password);

                var folders = client.GetFolders(new FolderNamespace('/', "[Gmail]"));

                foreach (var folder in folders)
                {
                    folder.Open(FolderAccess.ReadOnly);
                    progress.Report(folder);
                }

                client.Disconnect(true);
            }
        }

        public MimeMessage GetMailById(string messageId)
        {
            using (ImapClient client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(UserData.Email, UserData.Password);

                IMailFolder inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                var results = inbox.Search(SearchQuery.HeaderContains("Message-ID", messageId));

                foreach (var result in results)
                {
                    MimeMessage message = inbox.GetMessage(result);
                    if (message.MessageId == messageId)
                    {
                        return message;
                    }
                }
                client.Disconnect(true);
                return null;
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
