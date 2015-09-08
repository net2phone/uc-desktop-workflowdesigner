using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Page : IActivity
    {
        public string endpoints { get; set; }

        public Page()
        {
            MaxConectors = 1;
        }


        public override string ToString()
        {
            return "Page(" + endpoints + ")";
        }
      
    }
}
