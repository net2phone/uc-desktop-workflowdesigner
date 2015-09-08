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
    /// Interaction logic for VOLUMEProperty.xaml
    /// </summary>
    public partial class VOLUMEProperty : UserControl
    {
        VOLUME s { get; set; }

        public VOLUMEProperty()
        {
            InitializeComponent();
        }


        public override string ToString()
        {
            s = (VOLUME)base.Tag;

            Binding myBinding = new Binding("type");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = s;
            txttype.SetBinding(ComboBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("value");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = s;
            txtval.SetBinding(TextBox.TextProperty, myBinding2);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }

    }
}
