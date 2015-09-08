using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class DBExists : IActivity
    {
        public string family { get; set; }
        public string key { get; set; }
        public string varname { get; set; }

        public DBExists()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return "Set(" + varname + "=${DB_EXISTS(" + family + "/" + key + ")})";

        }
    }
}
