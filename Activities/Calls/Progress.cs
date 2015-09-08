using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class Progress : IActivity
    {
        public Progress()
        {
            MaxConectors = 1;
        }

         public override string ToString()
        {
            return "Progress()";
        }
    }
}
