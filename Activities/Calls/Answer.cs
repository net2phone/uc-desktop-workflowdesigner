using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Answer : IActivity
    {
        public string delay { get; set; }

        public Answer()
        {
            MaxConectors = 1;
        }


        public override string ToString()
        {
            return "Answer(" + delay + ")";
        }
      
    }
}
