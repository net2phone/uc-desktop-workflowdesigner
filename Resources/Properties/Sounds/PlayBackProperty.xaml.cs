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
    /// Interaction logic for PlayBackProperty.xaml
    /// </summary>
    public partial class PlayBackProperty : UserControl
    {
        PlayBack g { get; set; }

        public PlayBackProperty()
        {
            InitializeComponent();

      
        }
     
      

        public override string ToString()
        {

            g = (PlayBack)base.Tag;

            Binding myBinding = new Binding("filename");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            cmbfilename.SetBinding(ComboBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("options");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtopt.SetBinding(TextBox.TextProperty, myBinding2);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
