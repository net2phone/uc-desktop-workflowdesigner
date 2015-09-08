using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class SetCallerID : IActivity
    {
        public string var { get; set; }
        public string value { get; set; }

        public SetCallerID()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(CALLERID(" + var + ")=" + value + ")";
        }
    }
}
