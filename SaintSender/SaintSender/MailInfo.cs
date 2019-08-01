using MailKit;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    public class MailInfo
    {
        public MailInfo(MimeMessage message, UniqueId uid, IMailFolder parentFolder)
        {
            Message = message;
            Uid = uid;
            ParentFolder = parentFolder;
        }

        public MimeMessage Message { get; }
        public UniqueId Uid { get; }
        public IMailFolder ParentFolder { get; }
    }
}
