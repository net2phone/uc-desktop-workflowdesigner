using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntegraDesigner.Resources.Properties
{
    /// <summary>
    /// Interaction logic for BusyProperty.xaml
    /// </summary>
    public partial class BusyProperty : UserControl
    {

        public Busy b { get; set; }

        public BusyProperty()
        {
            InitializeComponent();
        }


        public override string ToString()
        {


            b = (Busy)base.Tag;
            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = b;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }

    }
}
