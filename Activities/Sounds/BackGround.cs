using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class BackGround : IActivity
    {
        public string filename { get; set; }
        public string options { get; set; }
        public string langoverride { get; set; }
        public string context { get; set; }

        public BackGround()
        {
            MaxConectors = 1;
        }

        public override string  ToString()
        {
            return "Background(" + filename + "," + options + "," + langoverride +"," + context + ")";
        }
     

    }
}
