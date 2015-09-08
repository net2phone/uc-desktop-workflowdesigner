using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
   public class Record : IActivity
    {
        public string filename { get; set; }
        public string format { get; set; }
        public int silence { get; set; }
        public long maxduration { get; set; }
        public string option { get; set; }

        public Record()
        {
            MaxConectors = 1;
        }
        public override string ToString()
        {
            return "Record(" + filename + "." + format + "," + silence + "," + maxduration + "," + option + ")";
        }
    }
}
