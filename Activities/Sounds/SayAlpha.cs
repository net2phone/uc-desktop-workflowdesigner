using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class SayAlpha : IActivity
    {
        public string alpha { get; set; }

        public SayAlpha()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "SayAlpha(" + alpha + ")";
        }

    }
}
