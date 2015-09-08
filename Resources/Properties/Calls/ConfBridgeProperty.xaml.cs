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
    /// Interaction logic for MeetMeProperty.xaml
    /// </summary>
    public partial class ConfBridgeProperty : UserControl
    {
        ConfBridge m { get; set; }

        public ConfBridgeProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            m = (ConfBridge)base.Tag;

            Binding myBinding = new Binding("confno");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = m;
            txtconf.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding3 = new Binding("bridge_profile");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = m;
            txtbp.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("user_profile");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = m;
            txtup.SetBinding(TextBox.TextProperty, myBinding4);
          
            Binding myBinding5 = new Binding("menu");
            myBinding5.Mode = BindingMode.TwoWay;
            myBinding5.Source = m;
            txtm.SetBinding(TextBox.TextProperty, myBinding5);



            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = m;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);



            return base.ToString();
        }

    }
}
