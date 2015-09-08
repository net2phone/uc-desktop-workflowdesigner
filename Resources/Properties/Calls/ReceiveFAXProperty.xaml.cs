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
    /// Interaction logic for FaxProperty.xaml
    /// </summary>
    public partial class ReceiveFAXProperty : UserControl
    {
        ReceiveFAX d { get; set; }

        public ReceiveFAXProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            d = (ReceiveFAX)base.Tag;

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = d;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
          
    }
}
