using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class ConfBridge : IActivity
    {
        public string confno { get; set; }
        public string bridge_profile { get; set; }
        public string user_profile { get; set; }
        public string menu { get; set; }

        //Check Confbridge.conf

        public ConfBridge()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "ConfBridge(" + confno + "," + bridge_profile + "," + user_profile + "," + menu + ")";
        }
       
    }
}
