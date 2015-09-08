using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class NoOp : IActivity
    {
        public string variable { get; set; }

        public NoOp()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "NoOp(" + variable + ")";
        }
    }
}
