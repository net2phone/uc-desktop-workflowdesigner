using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class SetLanguage : IActivity
    {
        public string language { get; set; }

        public SetLanguage()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "Set(CHANNEL(Language)=" + language + ")";
        }
    }
}
