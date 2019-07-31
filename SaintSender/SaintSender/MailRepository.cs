using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Runtime.InteropServices;

namespace SaintSender
{
    public class MailRepository
    {
        private readonly string mailServer, login, password;
        private readonly int port;
        private readonly bool ssl;

        public MailRepository(string mailServer, int port, bool ssl, string login, string password)
        {
            this.mailServer = mailServer;
            this.port = port;
            this.ssl = ssl;
            this.login = login;
            this.password = password;
        }

        public int MaxEmails { get; set; }

        public void GetAllMails(IProgress<MimeMessage> progress, [Optional] DateTime dateFrom)
        {
            if (dateFrom == new DateTime(0001, 01, 01, 0, 0, 0)) dateFrom = DateTime.Today.AddDays(-7);

            using (ImapClient client = new ImapClient())
            {
                client.Connect(mailServer, port, ssl);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(login, password);

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
    }
}
