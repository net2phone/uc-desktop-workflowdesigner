using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class GotoIfTime : IActivity
    {

        public string timerange { get; set; }
        public string daysofweek { get; set; }
        public string daysofmonth { get; set; }
        public string months { get; set; }
        public string context { get; set; }
        public string extension { get; set; }
        public int pri { get; set; }

         // <time range>= <hour>':'<minute>'-'<hour>':'<minute>  
         //              | "*" 
         //<days of week> = <dayname> 
         //              |  <dayname>'-'<dayname> 
         //              | "*" 
         //<dayname> = "sun" | "mon" | "tue" | "wed" | "thu" | "fri" | "sat" 
         //<days of month> = <daynum> 
         //               |  <daynum>'-'<daynum> 
         //               | "*" 
         //<daynum> = a number, 1 to 31, inclusive 
         //<hour> = a number, 0 to 23, inclusive 
         //<minute> = a number, 0 to 59, inclusive 
         //<months> = <monthname> 
         //           | <monthname>'-'<monthname> 
         //           | "*" 
         //<monthname> = "jan" | "feb" | "mar" | "apr" | "may" | "jun" | "jul" | "aug" | "sep" | "oct" | "nov" | "dec" 

        public GotoIfTime()
        {
            MaxConectors = 2;
        }

        public override string ToString()
        {
            return   "GotoIfTime(" + timerange + "," + daysofweek + "," + daysofmonth + "," + months + "?" + context + ",${EXTEN}," + DefaultPath + ")";
        }

    }
}
