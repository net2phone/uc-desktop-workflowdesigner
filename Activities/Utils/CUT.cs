using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class CUT : IActivity
    {
        public string result { get; set; }
        public string variable { get; set; }
        public string delimiter { get; set; }
        public string fieldspec { get; set; }

        public CUT()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(" + result + "=${CUT(" + variable + "," + delimiter + "," + fieldspec + ")})";
        }
    }
}
