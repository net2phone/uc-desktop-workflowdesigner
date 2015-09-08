using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class ExtenSpy : IActivity
    {
        public string extension { get; set; }
        public string context { get; set; }
        public string options { get; set; }

        public ExtenSpy()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
          return "ExtenSpy(" + extension + "@" + "context" + "," + options + ")";
        }
    }
}
