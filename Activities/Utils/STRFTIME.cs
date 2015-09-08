using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class STRFTIME : IActivity
    {
        public string result { get; set; }
        public string var { get; set; }
        public string timezone { get; set; }
        public string format { get; set; }

        public STRFTIME()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(" + result + "=${STRFTIME(" + var + "," + timezone + "," + format + ")})";
        }
    }
}
