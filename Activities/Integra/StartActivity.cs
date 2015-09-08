using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class StartActivity : IActivity
    {
      
        public string context { get; set; }
        public string exten { get; set; }

        public StartActivity()
        {
            MaxConectors = 1;
           
        }


        public override string ToString()
        {
            return "";
        }
       

    }
}
