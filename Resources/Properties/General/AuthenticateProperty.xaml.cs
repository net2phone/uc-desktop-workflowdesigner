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
    /// Interaction logic for AuthenticateProperty.xaml
    /// </summary>
    public partial class AuthenticateProperty : UserControl
    {
        Authenticate a { get; set; }

        public AuthenticateProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            a = (Authenticate)base.Tag;

            Binding myBinding = new Binding("password");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = a;
            txtpass.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("options");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = a;
            txtopt.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("maxdigits");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = a;
            txtmax.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("prompt");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = a;
            txtprompt.SetBinding(TextBox.TextProperty, myBinding4);



            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = a;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
