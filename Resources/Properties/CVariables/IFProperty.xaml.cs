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
    /// Interaction logic for IFProperty.xaml
    /// </summary>
    public partial class IFProperty : UserControl
    {
        IF s { get; set; }


        public IFProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            s = (IF)base.Tag;

            Binding myBinding = new Binding("result");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = s;
            txtres.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("condition");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = s;
            txtexp.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("res1");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = s;
            txttrue.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("res2");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = s;
            txtfalse.SetBinding(TextBox.TextProperty, myBinding4);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }

    }
}
