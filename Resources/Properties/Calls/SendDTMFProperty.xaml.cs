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
    /// Interaction logic for SendDTMFProperty.xaml
    /// </summary>
    public partial class SendDTMFProperty : UserControl
    {
        SendDTMF g { get; set; }

        public SendDTMFProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (SendDTMF)base.Tag;

            Binding myBinding = new Binding("digits");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtdigits.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding1 = new Binding("timeout");
            myBinding1.Mode = BindingMode.TwoWay;
            myBinding1.Source = g;
            txttimeout.SetBinding(TextBox.TextProperty, myBinding1);

            Binding myBinding2 = new Binding("duration");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtduration.SetBinding(TextBox.TextProperty, myBinding2);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
