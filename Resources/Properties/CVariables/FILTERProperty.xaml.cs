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
    /// Interaction logic for FILTERProperty.xaml
    /// </summary>
    public partial class FILTERProperty : UserControl
    {
        FILTER g { get; set; }

        public FILTERProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (FILTER)base.Tag;

            Binding myBinding = new Binding("resultvarname");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtvarn.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("allowedchars");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtallow.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("variable");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = g;
            txtvar.SetBinding(TextBox.TextProperty, myBinding3);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
