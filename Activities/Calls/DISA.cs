using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class DISA : IActivity
    {
        public string password { get; set; }
        public string context { get; set; }
        public string cid { get; set; }
        public string options { get; set; }

        public DISA()
        {
            MaxConectors = 1;
        }


        public override string ToString()
        {
            return "DISA(" + password + "," + context +"," + cid + ",," + options +  ")";
        }
      
    }
}
