using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class ForkCDR : IActivity
    {
        public string options { get; set; }

        public ForkCDR()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "ForkCDR(" + options + ")";
        }
    }
}
