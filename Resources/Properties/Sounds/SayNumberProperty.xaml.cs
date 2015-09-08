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
    /// Interaction logic for SayNumberProperty.xaml
    /// </summary>
    public partial class SayNumberProperty : UserControl
    {
        SayNumber g { get; set; }

        public SayNumberProperty()
        {
            InitializeComponent();
        }

        public override string  ToString()
        {
            g = (SayNumber)base.Tag;

            Binding myBinding = new Binding("number");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtnum.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("gender");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtgender.SetBinding(TextBox.TextProperty, myBinding2);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
