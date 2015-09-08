using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner 
{
    class AGI : IActivity
    {
        public string command { get; set; }
        public AGI()
        {
            MaxConectors = 1;
        }


        public override string ToString()
        {
            return "AGI(" + command + ")";
            
        }
    }
}
