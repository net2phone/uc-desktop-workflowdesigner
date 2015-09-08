using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class MeetMe : IActivity
    {
        public string confno { get; set; }
        public string options { get; set; }
        public string pin { get; set; }

        public MeetMe()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "MeetMe(" + confno + "," + options + "," + pin + ")";
        }
       
    }
}
