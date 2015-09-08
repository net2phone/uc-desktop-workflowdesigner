using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace IntegraDesigner
{
    public class Dialplan
    {
        public dialplanPK dialplanPK { get; set; }
        public String dialplan { get; set; }
        public String savedflow { get; set; }
        public String description { get; set; }
    }
}
