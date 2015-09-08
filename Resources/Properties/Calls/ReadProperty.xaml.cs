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
using System.Net;
using System.Xml;
using System.IO;

namespace IntegraDesigner.Resources.Properties
{
    /// <summary>
    /// Interaction logic for ReadProperty.xaml
    /// </summary>
    public partial class ReadProperty : UserControl
    {
        Read r { get; set; }

        public ReadProperty()
        {
            InitializeComponent();

        }

     

      

        public override string ToString()
        {
            r = (Read)base.Tag;

            Binding myBinding = new Binding("variable");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = r;
            txtvar.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("filename");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = r;
            cmbfilename.SetBinding(ComboBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("maxdigits");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = r;
            txtmax.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("option");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = r;
            txtopt.SetBinding(ComboBox.TextProperty, myBinding4);

            Binding myBinding5 = new Binding("attempts");
            myBinding5.Mode = BindingMode.TwoWay;
            myBinding5.Source = r;
            txtatt.SetBinding(TextBox.TextProperty, myBinding5);

            Binding myBinding6 = new Binding("timeout");
            myBinding6.Mode = BindingMode.TwoWay;
            myBinding6.Source = r;
            txttimeout.SetBinding(TextBox.TextProperty, myBinding6);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = r;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
