using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Read : IActivity
    {
        public string variable { get; set; }
        public string filename { get; set; }
        public int maxdigits { get; set; }
        public string option { get; set; }
        public int attempts { get; set; }
        public int timeout { get; set; }

        public Read()
        {
            MaxConectors = 1;
        }
    

          public override string  ToString()
            {
 	             return "Read(" + variable + "," + filename + "," + maxdigits + "," + option + "," + attempts + "," + timeout + ")" ;
            }
    }
}
