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
    /// Interaction logic for SetProperty.xaml
    /// </summary>
    public partial class SetProperty : UserControl
    {
        Set g { get; set; }

        public SetProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (Set)base.Tag;

            Binding myBinding = new Binding("variablename");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtvar.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("value");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtval.SetBinding(TextBox.TextProperty, myBinding2);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
