using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class AES_ENCRYPT : IActivity
    {
        public string varname { get; set; }
        public string key { get; set; } //16 characters
        public string toencrypt { get; set; }

        public AES_ENCRYPT()
	        {
                MaxConectors = 1;
	        }

        public override string ToString()
        {
            return "Set(" + varname + "=${AES_ENCRYPT(" + key +  "," + toencrypt + ")})";
        }

    }
}
