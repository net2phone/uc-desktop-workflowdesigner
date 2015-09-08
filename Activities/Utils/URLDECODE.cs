using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class URLDECODE : IActivity
    {
        public string result { get; set; }
        public string toencode { get; set; }

        public URLDECODE()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(" + result + "${URLDECODE(" + toencode + ")})";
        }
    }
}
