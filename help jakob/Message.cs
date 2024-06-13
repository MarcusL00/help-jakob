using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help_jakob
{
    public class Message : ISendMsg, ISendMsgAll
    {

        string to, from, body, subject, cc;
        Convert convert = new Convert();

        public Message(string to, string from, string body, string subject, string cc)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
        }

        public string To { get => to; set => to = value; }
        public string From { get => from; set => from = value; }
        public string Body { get => body; set => body = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Cc { get => cc; set => cc = value; }



        public void SendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = convert.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
        public void SendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
            {
                if (type.Equals(MessageCarrier.Smtp))
                {
                    if (isHTML)
                        m.Body = convert.ConvertBodyToHTML(m.Body);
                    //her implementeres alt koden til at sende via Smtp
                }

                if (type.Equals(MessageCarrier.VMessage))
                {
                    if (isHTML)
                        m.Body = convert.ConvertBodyToHTML(m.Body);
                    //her implementeres alt koden til at sende via VMessage
                }
            }
        }
    }
