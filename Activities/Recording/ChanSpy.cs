using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class ChanSpy : IActivity
    {
        public string scanspec { get; set; }
        public string options { get; set; }

        public ChanSpy()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Chanspy(" + scanspec + "," + options + ")";
        }
       
    }
}
