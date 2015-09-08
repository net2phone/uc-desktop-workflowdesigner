using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class SystemExec : IActivity
    {
        public string command { get; set; }

        public SystemExec()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "System(" + command + ")";
        }
    
    }
}
