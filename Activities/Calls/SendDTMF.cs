using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class SendDTMF : IActivity
    {
        public String digits { get; set; }
        public int timeout { get; set; } //default 0.25
        public int duration { get; set; }

        public SendDTMF()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "SendDTMF(" + digits + "," + timeout  + "," +duration + ")";
        }
    }
}
