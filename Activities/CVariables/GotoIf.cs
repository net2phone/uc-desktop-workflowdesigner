using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class GotoIf : IActivity
    {
       public string condition { get; set; }
      

        public GotoIf()
        {
            MaxConectors = 2;
        }
        public override string  ToString()
        {
 	         return "GotoIf(" + condition + "?" + DefaultPath + ":" + AlternativePath + ")";
        }
       
     
    }
}
