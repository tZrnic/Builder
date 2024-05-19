using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IMailConstructor
    {
        IMailConstructor AddRecipient(string recipient);
        IMailConstructor AddSubject(string subject);
        IMailConstructor AddContent(string content);
        IMailConstructor AddAttachment(string attachment);
        IMailConstructor Reset();
        Mail Construct();
    }
}
