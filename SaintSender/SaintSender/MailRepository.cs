using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Security;
using MimeKit;
using System;
using System.Runtime.InteropServices;

namespace SaintSender
{
    public class MailRepository
    {
        private readonly UserData userData;
        private readonly string mailServer;
        private readonly int port;
        private readonly bool ssl;

        public MailRepository(string mailServer, int port, bool ssl, UserData userData)
        {
            this.mailServer = mailServer;
            this.port = port;
            this.ssl = ssl;
            this.userData = userData;
        }

        public int MaxEmails { get; set; }

        public void GetAllMails(IProgress<MimeMessage> progress, [Optional] DateTime dateFrom)
        {
            if (dateFrom == new DateTime(0001, 01, 01, 0, 0, 0)) dateFrom = DateTime.Today.AddDays(-7);

            using (ImapClient client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(userData.Email, userData.Password);

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

        public bool IsLoginSuccessfullyAuth()
        {
            using (ImapClient client = new ImapClient())
            {
                try
                {
                    client.Connect(mailServer, port, ssl);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(userData.Email, userData.Password);
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
