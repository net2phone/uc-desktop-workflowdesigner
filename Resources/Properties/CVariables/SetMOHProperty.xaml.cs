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
    /// Interaction logic for SetMOHProperty.xaml
    /// </summary>
    public partial class SetMOHProperty : UserControl
    {
        SetMOH s { get; set; }

        public SetMOHProperty()
        {
            InitializeComponent();
            
 
        }

      
        public override string ToString()
        {
            s = (SetMOH)base.Tag;

            Binding myBinding2 = new Binding("clase");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = s;
            cmbclass.SetBinding(ComboBox.TextProperty, myBinding2);



            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
