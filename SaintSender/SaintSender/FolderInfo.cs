using MailKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    public class FolderInfo
    {
        public FolderInfo(IMailFolder mailfolder, int size)
        {
            MailFolder = mailfolder;
            FolderSize = size;
        }

        public IMailFolder MailFolder { get; }
        public int FolderSize { get; set; }
    }
}
