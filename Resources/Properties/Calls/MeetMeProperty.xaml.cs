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
    public partial class MeetMeProperty : UserControl
    {
        MeetMe m { get; set; }

        public MeetMeProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            m = (MeetMe)base.Tag;

            Binding myBinding = new Binding("confno");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = m;
            txtconf.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding3 = new Binding("options");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = m;
            txtopt.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding2 = new Binding("pin");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = m;
            txtpin.SetBinding(TextBox.TextProperty, myBinding2);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = m;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);



            return base.ToString();
        }

    }
}
