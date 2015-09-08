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
    public partial class SendFAXProperty : UserControl
    {
        SendFAX d { get; set; }

        public SendFAXProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            d = (SendFAX)base.Tag;

            Binding myBinding = new Binding("path");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = d;
            txtpath.SetBinding(TextBox.TextProperty, myBinding);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = d;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
          
    }
}
