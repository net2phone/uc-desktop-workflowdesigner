using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class EndWhile : IActivity
    {
        public EndWhile()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "EndWhile()";
        }
    }
}
