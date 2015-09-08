using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class REGEX : IActivity
    {
        public string result { get; set; }
        public string expreg { get; set; }
        public string data { get; set; }

        public REGEX()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(" + result + "=${REGEX(\"" + expreg + "\" " + data + ")})";
        }
    }
}
