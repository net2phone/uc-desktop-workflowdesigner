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
    /// Interaction logic for AGIProperty.xaml
    /// </summary>
    public partial class AGIProperty : UserControl
    {
        AGI a { get; set; }

        public AGIProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            a = (AGI)base.Tag;

            Binding myBinding = new Binding("command");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = a;
            txtcom.SetBinding(TextBox.TextProperty, myBinding);



            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = a;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }

    }
}
