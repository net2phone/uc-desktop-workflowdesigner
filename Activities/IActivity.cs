using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class IActivity 
    {
        public int prio { get; set; }
        public string AppName { get; set; }
        public int MaxConectors { get; set; }
        public int ActualConections { get; set; }
        public int DefaultPath { get; set; }
        public int AlternativePath { get; set; }
        public bool Used { get; set; }
        public string Description { get; set; }
       
    }
}
