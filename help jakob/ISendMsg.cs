using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help_jakob
{
     interface ISendMsg
    {
        public void SendMessage(MessageCarrier type, Message m, bool isHTML);

    }
}
