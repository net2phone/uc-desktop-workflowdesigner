using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class include: IActivity
    {
        public string context { get; set; }
       

        public include()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "include => " + context;
        }
    
    }
}
