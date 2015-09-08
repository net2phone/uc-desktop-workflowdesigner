using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class MATH : IActivity
    {
        public string result { get; set; }
        public string val1 { get; set; }
        public string val2 { get; set; }
        public string oper { get; set; }
        public string resulttype { get; set; }

//        Perform calculation on number 1 to number 2. Valid ops are: 
//         +,-,/,*,%,<,>,>=,<=,== 
//        and behave as their C equivalents. 
//       <type_of_result> - wanted type of result: 
//       f, float - float(default) 
//       i, int - integer, 
//       h, hex - hex, 
//       c, char - char 

        public MATH()
        {
            MaxConectors = 1;
        }



        public override string ToString()
        {
            return "Set(" + result + "=${MATH(" + val1 + " " + oper + " " + val2 + "," + resulttype + ")})";
        }
    }
}
