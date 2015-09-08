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
    /// Interaction logic for OriginateProperty.xaml
    /// </summary>
    public partial class OriginateProperty : UserControl
    {
        Originate r { get; set; }

        public OriginateProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            r = (Originate)base.Tag;
            
            Binding myBinding = new Binding("tech_data");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = r;
            txttdata.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("type");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = r;
            cmbtype.SetBinding(ComboBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("arg1");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = r;
            txtarg1.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("arg2");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = r;
            txtarg2.SetBinding(TextBox.TextProperty, myBinding4);

            Binding myBinding5 = new Binding("arg3");
            myBinding5.Mode = BindingMode.TwoWay;
            myBinding5.Source = r;
            txtarg3.SetBinding(TextBox.TextProperty, myBinding5);
                     
            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = r;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
