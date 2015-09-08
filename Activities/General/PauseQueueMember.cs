using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class PauseQueueMember : IActivity
    {
        public string queuename { get; set; }
        public string interfac { get; set; }
        public string options { get; set; }
        public string reason { get; set; }


        public PauseQueueMember()
        {
            MaxConectors = 1; 
        }

        public override string ToString()
        {


            return "PauseQueueMember(" + queuename + "," + interfac + "," + options + "," + reason + ")";
        }
    }
}
