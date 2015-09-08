using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class StopPlayTones : IActivity
    {
        public string tonename { get; set; }

        public StopPlayTones()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "StopPlaytones()";
        }
    }
}

