using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class VOLUME : IActivity
    {
        public int value { get; set; }
        public string type { get; set; }

        public VOLUME()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "Set(VOLUME(" + type + ")" + "=" + value + ")";
        }
    }
}
