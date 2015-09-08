using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class VoiceMail : IActivity

    {
       public string boxnumber { get; set; }
       public string context { get; set; }
       public string flags { get; set; }

       public VoiceMail()
       {
           MaxConectors = 1;
       }
        public override string  ToString()
        {
 	         return "VoiceMail(" + boxnumber + "@" + context + "," + flags + ")";
        }
  



    }
}
