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
    /// Interaction logic for ChanSpyProperty.xaml
    /// </summary>
    public partial class ChanSpyProperty : UserControl
    {
        ChanSpy c { get; set; }

        public ChanSpyProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            c = (ChanSpy)base.Tag;

            Binding myBinding = new Binding("scanspec");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = c;
            txtspec.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("options");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = c;
            txtopt.SetBinding(TextBox.TextProperty, myBinding2);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = c;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
