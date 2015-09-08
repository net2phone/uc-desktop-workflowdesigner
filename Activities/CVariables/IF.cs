using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class IF : IActivity
    {
        public string result { get; set; }
        public string condition { get; set; }
        public string res1 { get; set; }
        public string res2 { get; set; }

        public IF()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "Set(" + result + "=${IF(" + condition + "?" + res1 + ":" + res2 + ")})";
        }
    }
}
