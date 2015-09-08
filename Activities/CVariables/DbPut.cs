using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class DBPut : IActivity
    {
        public string family { get; set; }
        public string key { get; set; }
        public string value { get; set; }

        public DBPut()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(DB(" + family + "/" + key + ")=" + value + ")";

        }
    }
}
