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
    /// Interaction logic for TransferProperty.xaml
    /// </summary>
    public partial class TransferProperty : UserControl
    {
        Transfer s { get; set; }

        public TransferProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            s = (Transfer)base.Tag;

            Binding myBinding = new Binding("destination");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = s;
            txtdest.SetBinding(TextBox.TextProperty, myBinding);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
