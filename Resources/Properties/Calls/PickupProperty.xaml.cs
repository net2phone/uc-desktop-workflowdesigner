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
    /// Interaction logic for PickupProperty.xaml
    /// </summary>
    public partial class PickupProperty : UserControl
    {
        public Pickup pick { get; set; }

        public PickupProperty()
        {
            InitializeComponent();
        }


        public override string ToString()
        {
            pick = (Pickup)base.Tag;

            Binding myBinding = new Binding("channels");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = pick;
            txtexten.SetBinding(TextBox.TextProperty, myBinding);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = pick;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
