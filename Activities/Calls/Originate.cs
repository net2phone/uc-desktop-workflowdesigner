using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class Originate : IActivity
    {
        public string tech_data { get; set; } //Channel technology and data for creating the outbound channel. For example, SIP/1234.
        public string type { get; set; } //This should be 'app' or 'exten', depending on whether the outbound channel should be connected to an application or extension. 
        public string arg1 { get; set; } //If the type is 'app', then this is the application name. If the type is 'exten', then this is the context that the channel will be sent to.
        public string arg2 { get; set; } //If the type is 'app', then this is the data passed as arguments to the application. If the type is 'exten', then this is the extension that the channel will be sent to.
        public string arg3 { get; set; } // If the type is 'exten', then this is the priority that the channel is sent to. If the type is 'app', then this parameter is ignored.

    
// This application originates an outbound call and connects it to a specified extension or application. This application will block until the outgoing call fails or gets answered. At that point, this application will exit with the status variable set and dialplan processing will continue.
//This application sets the following channel variable before exiting: ${ORIGINATE_STATUS}: This indicates the result of the call origination.
//Possible values:
//FAILED
//SUCCESS
//BUSY
//CONGESTION
//HANGUP
//RINGING
//UNKNOWN: In practice, you should never see this value.

      

        public Originate()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return  "Originate(" + tech_data + "," + type + "," + arg1 + "," + arg2 + "," + arg3 + ")";
        }
    }
}
