using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class Rand : IActivity
    {
        public string result { get; set; }
        public int min { get; set; }
        public int max { get; set; }

        public Rand()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(" + result + "=${RAND(" + min + "," + max + ")})";
        }
    }
}
