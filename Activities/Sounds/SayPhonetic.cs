using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class SayPhonetic : IActivity
    {
        public string text { get; set; }


        public SayPhonetic()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "SayPhonetic(" + text + ")";
        }
        
    }
}
