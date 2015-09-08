using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class SetMOH : IActivity
    {
        public string clase { get; set; }

        public SetMOH()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            
            return "Set(CHANNEL(musicclass)=" + clase + ")";
        }
    }
}
