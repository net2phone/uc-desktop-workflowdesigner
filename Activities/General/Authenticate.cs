using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Authenticate : IActivity
    {
        public string password { get; set; }
        public string options { get; set; }
        public string maxdigits { get; set; }
        public string prompt { get; set; }


        public Authenticate()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "Authenticate(" + password + "," + options + "," + maxdigits + "," + prompt +")";
        }
      
    }
}
