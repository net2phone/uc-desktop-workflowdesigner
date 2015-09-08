using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class MusicOnHold : IActivity
    {
        public String clase { get; set; }
        public int duration { get; set; } //-1 Indefinido

        public MusicOnHold()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "MusicOnHold(" + clase + "," + duration +")";
        }


    }
}
