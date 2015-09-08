using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class NoCDR : IActivity

    {
        public NoCDR()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "NoCDR()";
        }
    }
}
