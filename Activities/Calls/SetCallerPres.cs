using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner 
{
    public class SetCallerPres : IActivity
    {
        public string presentation { get; set; }

     //allowed_not_screened    : Presentation Allowed, Not Screened 
     //allowed_passed_screen   : Presentation Allowed, Passed Screen 
     //allowed_failed_screen   : Presentation Allowed, Failed Screen 
     //allowed                 : Presentation Allowed, Network Number 
     //prohib_not_screened     : Presentation Prohibited, Not Screened 
     //prohib_passed_screen    : Presentation Prohibited, Passed Screen 
     //prohib_failed_screen    : Presentation Prohibited, Failed Screen 
     //prohib                  : Presentation Prohibited, Network Number 
     //unavailable             : Number Unavailable 

        public SetCallerPres()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(CALLERID(name-pres)=" + presentation + ")";
        }
    }
}
