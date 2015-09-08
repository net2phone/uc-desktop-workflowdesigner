using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Set : IActivity
    {
        public string variablename { get; set; }
        public string value { get; set; }

        public Set()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(" + variablename + "=" + value + ")";
        }


    }
}
