using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class CURL : IActivity
    {
        public string variable  { get; set; }
        public string url { get; set; }
        public string postdata { get; set; }
        public bool isPost { get; set; }

        public CURL()
        {
            MaxConectors = 1;
        }

        public override string  ToString()
        {
            if (isPost)
                return "Set(" + variable + "=${CURL(" + url + "," + postdata + ")})";
            else
                return "Set(" + variable + "=${CURL(" + url + ")})";
        

        }
               

    
    }
}
