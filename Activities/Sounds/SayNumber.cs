using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class SayNumber : IActivity
    {
        public string number { get; set; }
        public string gender { get; set; }
        
        //"f" female 
        //"m" male 
        //"c" commune
        //"n" neuter 
        //"p" plural

        public SayNumber()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "SayNumber(" + number + "," + gender + ")";
        }
        
    }
}
