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
    /// Interaction logic for MATHProperty.xaml
    /// </summary>
    public partial class MATHProperty : UserControl
    {
        MATH s { get; set; }

        public MATHProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            s = (MATH)base.Tag;

            Binding myBinding = new Binding("result");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = s;
            txtres.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("val1");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = s;
            txtval1.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("val2");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = s;
            txtval2.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("oper");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = s;
            txtoper.SetBinding(ComboBox.TextProperty, myBinding4);

            Binding myBinding5 = new Binding("resulttype");
            myBinding5.Mode = BindingMode.TwoWay;
            myBinding5.Source = s;
            txttype.SetBinding(ComboBox.TextProperty, myBinding5);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);
           
            return base.ToString();
        }

    }
}
