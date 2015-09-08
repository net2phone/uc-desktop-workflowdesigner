using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class Pickup: IActivity
    {
        public String channels { get; set; }

        public Pickup()
        {
            MaxConectors = 1;
        }


        public override string ToString()
        {
            return "PickupChan(" + channels + ")";  //SIP/1001&SIP/1002
        }
    
    }
}
