using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class B64DECODE : IActivity
    {
        public string cadena { get; set; }
        public string result { get; set; }

            public B64DECODE ()
	        {
                MaxConectors = 1;
	        }

        public override string ToString()
        {
            return "Set(" + result + "=${BASE64_DECODE(" + cadena + ")})";
        }

    }
}
