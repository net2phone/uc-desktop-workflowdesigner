using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class StartMusicOnHold : IActivity
    {
        public string clase { get; set; }


        public StartMusicOnHold()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "StartMusicOnHold(" + clase + ")";
        }
    }
}
