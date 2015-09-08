using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class AES_DECRYPT : IActivity
    {
        public string varname { get; set; }
        public string key { get; set; } //16 characters
        public string todecrypt { get; set; }

        public AES_DECRYPT()
	        {
                MaxConectors = 1;
	        }

        public override string ToString()
        {
            return "Set(" + varname + "=${AES_DECRYPT(" + key +  "," + todecrypt + ")})";
        }

    }
}
