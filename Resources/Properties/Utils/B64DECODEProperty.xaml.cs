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
    /// Interaction logic for B64DECODEProperty.xaml
    /// </summary>
    public partial class B64DECODEProperty : UserControl
    {
        B64DECODE s { get; set; }

        public B64DECODEProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            s = (B64DECODE)base.Tag;

            Binding myBinding = new Binding("result");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = s;
            txtres.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("cadena");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = s;
            txtcadena.SetBinding(TextBox.TextProperty, myBinding2);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
