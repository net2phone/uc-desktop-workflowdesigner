using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class FILTER : IActivity
    {
        public string resultvarname { get; set; }
        public string allowedchars { get; set; }
        public string variable { get; set; }

        public FILTER()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(" + resultvarname + "=${FILTER(" + allowedchars + "," + variable + ")})";
        }

         
    }
}
