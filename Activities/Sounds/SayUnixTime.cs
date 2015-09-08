using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class SayUnixTime : IActivity
    {
        public string unixtime { get; set; }
        public string timezone { get; set; }
        public string format { get; set; }


        public SayUnixTime()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "SayUnixTime(" + unixtime + "," + timezone + "," + format + ")";
        }
    }
}
