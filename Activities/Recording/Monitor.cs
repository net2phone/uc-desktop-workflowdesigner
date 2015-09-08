using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Monitor : IActivity
    {
        public string ext { get; set; }
        public string basename { get; set; }
        public string flags { get; set; }

        public Monitor()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Monitor(" + ext + "," + basename + "," + flags + ")";
        }
    }
}
