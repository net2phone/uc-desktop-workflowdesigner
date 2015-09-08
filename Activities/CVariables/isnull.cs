using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class isnull : IActivity
    {
        public string result { get; set; }
        public string var { get; set; }

        public isnull()
        {
            MaxConectors = 1;
        }


        public override string ToString()
        {
            return "Set(" + result + "=${ISNULL(" + var + ")})";
        }
    }
}
