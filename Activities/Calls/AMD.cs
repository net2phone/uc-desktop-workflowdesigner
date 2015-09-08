using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegraDesigner
{
    public class AMD : IActivity
    {
        public string initialSilence { get; set; }
        public string greeting { get; set; }
        public string afterGreetingSilence { get; set; }
        public string totalAnalysisTime { get; set; }
        public string minWordLength { get; set; }
        public string betweenWordsSilence { get; set; }
        public string maxNumberOfWords { get; set; }
        public string silenceThreshold { get; set; }


      

        public AMD()
        {
            MaxConectors = 1;
        }

        public override string ToString()
        {
            return  "AMD(" + initialSilence + "," + greeting + "," + afterGreetingSilence + "," + totalAnalysisTime + "," + minWordLength + "," + betweenWordsSilence + "," + maxNumberOfWords + "," + silenceThreshold + ")";
        }
    }
}
