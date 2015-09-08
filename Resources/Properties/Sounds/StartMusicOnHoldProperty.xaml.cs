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
using System.Net;
using System.Xml;
using System.IO;

namespace IntegraDesigner.Resources.Properties
{
    /// <summary>
    /// Interaction logic for StartMusicOnHoldProperty.xaml
    /// </summary>
    public partial class StartMusicOnHoldProperty : UserControl
    {
        StartMusicOnHold g { get; set; }

        public StartMusicOnHoldProperty()
        {
            InitializeComponent();

        }
       

        public override string ToString()
        {
            g = (StartMusicOnHold)base.Tag;

            Binding myBinding = new Binding("clase");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            cmbclass.SetBinding(ComboBox.TextProperty, myBinding);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
