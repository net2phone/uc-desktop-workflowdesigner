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
    /// Interaction logic for RetryDialProperty.xaml
    /// </summary>
    public partial class RetryDialProperty : UserControl
    {
        RetryDial d { get; set; }

        public RetryDialProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            d = (RetryDial)base.Tag;

            Binding myBinding0 = new Binding("announce");
            myBinding0.Mode = BindingMode.TwoWay;
            myBinding0.Source = d;
            txtannounce.SetBinding(TextBox.TextProperty, myBinding0);

            Binding myBinding1 = new Binding("sleep");
            myBinding1.Mode = BindingMode.TwoWay;
            myBinding1.Source = d;
            txtsleep.SetBinding(TextBox.TextProperty, myBinding1);


            Binding myBinding6 = new Binding("retries");
            myBinding6.Mode = BindingMode.TwoWay;
            myBinding6.Source = d;
            txtretries.SetBinding(TextBox.TextProperty, myBinding6);


            Binding myBinding = new Binding("type");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = d;
            txttype.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("identifier");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = d;
            txtidentifier.SetBinding(TextBox.TextProperty, myBinding2);


            Binding myBinding3 = new Binding("timeout");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = d;
            txttimeout.SetBinding(TextBox.TextProperty, myBinding3);


            Binding myBinding4 = new Binding("options");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = d;
            txtoptions.SetBinding(TextBox.TextProperty, myBinding4);


            Binding myBinding5 = new Binding("URL");
            myBinding5.Mode = BindingMode.TwoWay;
            myBinding5.Source = d;
            txturl.SetBinding(TextBox.TextProperty, myBinding5);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = d;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
