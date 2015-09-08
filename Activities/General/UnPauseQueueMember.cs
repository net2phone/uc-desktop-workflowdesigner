using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class UnPauseQueueMember : IActivity
    {
        public string queuename { get; set; }
        public string interfac { get; set; }
        public string options { get; set; }
        public string reason { get; set; }


        public UnPauseQueueMember()
        {
            MaxConectors = 1; 
        }

        public override string ToString()
        {


            return "UnPauseQueueMember(" + queuename + "," + interfac + "," + options + "," + reason + ")";
        }
    }
}
