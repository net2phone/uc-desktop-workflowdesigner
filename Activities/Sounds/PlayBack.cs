using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class PlayBack : IActivity
    {
        public string filename { get; set; }
        public string options { get; set; }


        public PlayBack()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "Playback(" + filename + "," + options + ")";
        }
    }
}
