using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class VMAutenticate : IActivity
    {
       public string mailbox { get; set; }
        public string context { get; set; }
        public string options { get; set; }

        public VMAutenticate()
        {
            MaxConectors = 1;
        }

        public override string  ToString()
        {
            return "VMAuthenticate(" + mailbox + "@" + context + "," + options + ")";
        }

        
    }
}
