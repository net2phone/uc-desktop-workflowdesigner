using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class RetryDial : IActivity
    {
        public String announce { get; set; }
        public int sleep { get; set; }
        public int retries { get; set; }
        public String type { get; set; }
        public String identifier { get; set; }
        public int timeout { get; set; }
        public String options { get; set; }
        public String URL { get; set; }


        public RetryDial()
        {
            MaxConectors = 1;
        }


        public override string ToString()
        {
            return "RetryDial(" + announce + "," + sleep + "," + retries + "," + type + "/" + identifier + "," + timeout + "," + options + "," + URL + ")";
        }


    }
}
