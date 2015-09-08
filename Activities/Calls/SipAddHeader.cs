using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class SipAddHeader : IActivity
    {
        public string header { get; set; }

        public SipAddHeader()
        {
            MaxConectors = 1;
        }


        public override string ToString()
        {
            return "SipAddHeader(" + header + ")";
        }
      
    }
}
