using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class ARRAY : IActivity
    {
        public string variables { get; set; }
        public string values { get; set; }

        public ARRAY()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(ARRAY(" + variables + ")=" + values + "))";
        }

         

    }
}
