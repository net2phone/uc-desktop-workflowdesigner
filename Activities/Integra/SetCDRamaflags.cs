using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class SetCDRamaflags : IActivity
    {
        public string flag { get; set; }
        
        ///default,omit,billing,documentation

        public SetCDRamaflags()
        {
            MaxConectors = 1;

        }

        public override string ToString()
        {
            

            return "Set(CDR(amaflags) = " + flag + ")";
        }

    }
}
