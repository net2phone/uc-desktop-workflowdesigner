using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class ChannelRedirect : IActivity
    {
        public string Channel { get; set; }
        public string context { get; set; }
        public string extension { get; set; }
        public int pri { get; set; }

        public ChannelRedirect()
        {
            MaxConectors = 1;
        }

        public override string  ToString()
        {
            return "ChannelRedirect("+ Channel + "," + context + "," + extension + "," + pri + ")";
        }
       
    }
}
