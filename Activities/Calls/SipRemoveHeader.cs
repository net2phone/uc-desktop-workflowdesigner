using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class SipRemoveHeader : IActivity
    {
        public string header { get; set; }

        public SipRemoveHeader()
        {
            MaxConectors = 1;
        }


        public override string ToString()
        {
            return "SIPRemoveHeader(" + header + ")";
        }
      
    }
}
