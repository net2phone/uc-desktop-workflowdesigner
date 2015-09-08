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
    /// Interaction logic for StartActivityProperty.xaml
    /// </summary>
    public partial class StartActivityProperty : UserControl
    {
        StartActivity s { get; set; }

        public StartActivityProperty()
        {
            InitializeComponent();


        }





        public override string ToString()
        {
            s = (StartActivity)base.Tag;

            Binding myBinding = new Binding("context");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = s;
            cmbcontext.SetBinding(ComboBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("exten");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = s;
            txtdnis.SetBinding(TextBox.TextProperty, myBinding2);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }

    }
       
}
