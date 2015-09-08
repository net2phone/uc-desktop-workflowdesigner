using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Goto : IActivity
    {
        public string context { get; set; }
        public string extension { get; set; }
        public int pri { get; set; }

        public Goto()
        {
            MaxConectors = 1;
        }

        public override string  ToString()
        {
 	         return "Goto(" + context + "," + extension + "," + pri + ")";
        }
       
    }
}
