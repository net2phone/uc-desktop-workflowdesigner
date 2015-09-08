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
    /// Interaction logic for SayDigitsProperty.xaml
    /// </summary>
    public partial class SayDigitsProperty : UserControl
    {
        SayDigits g { get; set; }

        public SayDigitsProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (SayDigits)base.Tag;

            Binding myBinding = new Binding("digits");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtdigits.SetBinding(TextBox.TextProperty, myBinding);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
