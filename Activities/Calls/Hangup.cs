using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Hangup : IActivity
    {
        public Hangup()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "Hangup()";
        }
    }
}
