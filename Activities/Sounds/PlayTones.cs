using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class PlayTones : IActivity
    {
        public string tonename { get; set; }

        public PlayTones()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Playtones(" + tonename + ")";
        }
    }
}
