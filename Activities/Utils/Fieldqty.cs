using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class Fieldqty : IActivity
    {
        public string result { get; set; }
        public string variable { get; set; }
        public string delimiter { get; set; }

        public Fieldqty()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(" + result + "=${FIELDQTY(" + variable + "," + delimiter +")})";
        }
    }
}
