using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Queue : IActivity
    {
        public string queuename { get; set; }
        public string options { get; set; }
        public string URL { get; set; }
        public string announceoverride { get; set; }
        public int timeout { get; set; }
        public string AGI { get; set; }
        public string macro { get; set; }
        public string gosub { get; set; }
        public string rule  { get; set; }
        public string position { get; set; }

        public Queue()
        {
            MaxConectors = 1;
        }

        public override string  ToString()
        {
 	         return "Queue(" + queuename + "," + options + "," + URL + "," + announceoverride + "," + timeout + "," + AGI + "," + macro + "," + gosub + "," + rule + "," + position + ")";
        }
    



    }
}
