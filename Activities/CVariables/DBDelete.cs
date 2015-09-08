using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class DBDelete : IActivity
    {
        public string family { get; set; }
        public string key { get; set; }
 

        public DBDelete()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "NoOp(${DB_DELETE(" + family + "/" + key + ")})";

        }
    }
}
