using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class Log : IActivity
    {
        public string level { get; set; }
        public string message { get; set; }

        public Log()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Log(" + level + "," + message + ")";
        }
    }
}
