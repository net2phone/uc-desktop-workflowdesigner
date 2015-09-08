using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class VoiceMailMain : IActivity
    {
       public string mailbox { get; set; }
       public string context { get; set; }
       public string options { get; set; }

       public VoiceMailMain()
       {
           MaxConectors = 1;
       }

        public override string  ToString()
        {
 	         return "VoiceMailMain(" + mailbox + "@" + context + "," + options + ")";
        }
                


    }
}
