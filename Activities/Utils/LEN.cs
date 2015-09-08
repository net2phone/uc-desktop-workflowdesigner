using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class LEN : IActivity
    {
        public string result { get; set; }
        public string var { get; set; }

        public LEN()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {

            return "Set(" + result + "=${LEN(" + var + ")})";
        }
    }
}
