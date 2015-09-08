using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class STAT : IActivity
    {
        public string result { get; set; }
        public string flag { get; set; }
        public string filename { get; set; }

        public STAT()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(" + result + "=${STAT(" + flag + "," + filename + ")})";
        }
    }
}
