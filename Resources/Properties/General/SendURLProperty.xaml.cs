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
    /// Interaction logic for SendURLProperty.xaml
    /// </summary>
    public partial class SendURLProperty : UserControl
    {
        SendURL u { get; set; }

        public SendURLProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            u = (SendURL)base.Tag;

            Binding myBinding = new Binding("URL");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = u;
            txturl.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("option");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = u;
            txtopt.SetBinding(TextBox.TextProperty, myBinding2);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source =u;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
