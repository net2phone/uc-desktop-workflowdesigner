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
    /// Interaction logic for NoOpProperty.xaml
    /// </summary>
    public partial class NoOpProperty : UserControl
    {
        NoOp s { get; set; }

        public NoOpProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            s = (NoOp)base.Tag;


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            Binding varbinding = new Binding("variable");
            varbinding.Mode = BindingMode.TwoWay;
            varbinding.Source = s;
            txtvar.SetBinding(TextBox.TextProperty, varbinding);

            return base.ToString();
        }

    }
}
