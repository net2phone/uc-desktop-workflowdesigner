using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class DinstarSendSMS : IActivity
    {
        public string destination { get; set; }
        public string message { get; set; }
        public string campaign { get; set; }

        public string url { get; set; }
        public string postdata { get; set; }

        public DinstarSendSMS()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            url = "http://" + Config.ServerIP + ":" + Config.port + "/Integra/resources/SMS/SendPOSTSMS";
            postdata = "destination=" + destination + "&message=" + message + "&api=Dinstar&campaign=" + campaign;

            return "Set(result=${CURL(" + url + "," + postdata + ")})";
        }
    }
}
