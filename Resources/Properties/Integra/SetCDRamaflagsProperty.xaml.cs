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
    /// Interaction logic for SetCDRamaflagsProperty.xaml
    /// </summary>
    public partial class SetCDRamaflagsProperty : UserControl
    {
        SetCDRamaflags s { get; set; }

        public SetCDRamaflagsProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            s = (SetCDRamaflags)base.Tag;


            Binding myBinding2 = new Binding("flag");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = s;
            txtflag.SetBinding(TextBox.TextProperty, myBinding2);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }

    }
}
