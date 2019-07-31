using System;
using System.IO;
using System.Windows.Forms;

namespace SaintSender
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (File.Exists(@"AppData\login.dat"))
            {
                UserData userData = DataService.DeSerializeLoginData();
                Application.Run(new MainForm(new MailRepository("imap.gmail.com", 993, true, userData)));
            }
            else
            {
                Application.Run(new LoginForm());
            }
        }
    }
}
