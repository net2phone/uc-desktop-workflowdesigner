using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class SendFAX : IActivity
    {
        public String path { get; set; }

        public SendFAX()
        {
            MaxConectors = 1;
        }
        
        public override string ToString()
        {
            return "SendFAX(" + path  +")";
        }
    }
}
