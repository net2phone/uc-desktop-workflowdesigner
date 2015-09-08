using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class SayDigits : IActivity
    {
        public string digits { get; set; }

        public SayDigits()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "SayDigits(" + digits + ")";
        }
    }
}
