using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class MessageSend : IActivity
    {
        public string variable { get; set; }

        public MessageSend()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "MessageSend(" + variable + ")";
        }
    }
}
