using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class Transfer : IActivity
    {
        public string destination { get; set; }

        public Transfer()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Transfer(" + destination +")";
        }
    }
}
