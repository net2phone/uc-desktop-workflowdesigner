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
    /// Interaction logic for SMSProperty.xaml
    /// </summary>
    public partial class DinstarSendSMSProperty : UserControl
    {
        DinstarSendSMS s { get; set; }

        public DinstarSendSMSProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            s = (DinstarSendSMS)base.Tag;

            Binding myBinding = new Binding("campaign");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = s;
            txtdev.SetBinding(TextBox.TextProperty, myBinding);


            Binding myBinding2 = new Binding("destination");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = s;
            txtopt.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("message");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = s;
            txtmes.SetBinding(TextBox.TextProperty, myBinding3);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
