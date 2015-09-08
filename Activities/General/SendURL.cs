using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class SendURL : IActivity
    {
        public string URL { get; set; }
        public string option { get; set; } //wait (a que termine la ejecucion)

        public SendURL()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "SendURL(" + URL+ "," + option + ")";
        }
    }
}
