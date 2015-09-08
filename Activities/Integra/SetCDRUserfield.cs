using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class SetCDRUserfield : IActivity
    {

        public string userfield { get; set; }

        public SetCDRUserfield()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {


            return "Set(CDR(userfield)=" + userfield + ")";
        }

    }
}
