using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class ReceiveFAX : IActivity
    {
       public string FaxFile { get; set; }

        public ReceiveFAX()
        {
            MaxConectors = 1;
        }


       public override string ToString()
        {
            return "ReceiveFAX(/var/spool/asterisk/monitor/${guid}.tif)";
        }
    }
}
