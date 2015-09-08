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
    /// Interaction logic for GotoIfProperty.xaml
    /// </summary>
    public partial class GotoIfProperty : UserControl
    {
        GotoIf g { get; set; }

        public GotoIfProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (GotoIf)base.Tag;

            Binding myBinding = new Binding("condition");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtcond.SetBinding(TextBox.TextProperty, myBinding);



            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
