using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class UserEvent : IActivity
    {
        public string EventName { get; set; }
        public string URL { get; set; }
        public string APP { get; set; }
        public string Body { get; set; }
      

        public UserEvent()
        {
            MaxConectors = 1; 
        }

        public override string ToString()
        {


            return "UserEvent(" + EventName + "," + Body + ")";
        }
    }
}
