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
    /// Interaction logic for MixMonitorProperty.xaml
    /// </summary>
    public partial class MixMonitorProperty : UserControl
    {
        MixMonitor g { get; set; }

        public MixMonitorProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (MixMonitor)base.Tag;

            Binding myBinding = new Binding("filename");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtfile.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("options");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtopt.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("command");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = g;
            txtcmd.SetBinding(TextBox.TextProperty, myBinding3);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
