using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Dial : IActivity
    {
        public string type { get; set; }
        public string identifier { get; set; }
        public int timeout { get; set; }
        public string options { get; set; }
        public string url { get; set; }

        public Dial()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Dial(" + type + "/" + identifier + "," + timeout + "," + options + "," + url + ")";
        }
        

    }
}
