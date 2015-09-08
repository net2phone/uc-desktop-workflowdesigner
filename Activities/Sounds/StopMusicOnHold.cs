using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class StopMusicOnHold : IActivity
    {
        public string clase { get; set; }


        public StopMusicOnHold()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "StopMusicOnHold()";
        }
    }
}
