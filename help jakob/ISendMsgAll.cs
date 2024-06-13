using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help_jakob
{
    internal interface ISendMsgAll
    {
        public void SendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {

        }
    }
}
