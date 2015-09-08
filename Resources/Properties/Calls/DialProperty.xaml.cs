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
    /// Interaction logic for DialProperty.xaml
    /// </summary>
    public partial class DialProperty : UserControl
    {
        Dial d { get; set; }

        public DialProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            d = (Dial)base.Tag;

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


            Binding myBinding5 = new Binding("url");
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
