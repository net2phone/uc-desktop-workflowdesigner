using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class Ringing :IActivity 
    {

        public Ringing()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Ringing";
        }
    }
}
