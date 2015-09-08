using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
   public class ControlPlayback : IActivity
    {
        public string filename { get; set; }
        public string skipms { get; set; }
        public string ff { get; set; }
        public string rew { get; set; }
        public string stop { get; set; }
        public string pause { get; set; }
        public string restart { get; set; }
        public string options { get; set; } //o(time)

        public ControlPlayback()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "ControlPlayback(" + filename + "," + skipms + "," + ff + "," + rew + "," + stop + "," + pause + "," + restart + "," + options + ")";
        }
    }


}
