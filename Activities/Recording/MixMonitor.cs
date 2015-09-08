using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class MixMonitor : IActivity
    {
        public string filename { get; set; }
        public string options { get; set; }
        public string command { get; set; }

        public MixMonitor()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "MixMonitor(" + filename + "," + options + "," + command + ")";
        }
    }
}
