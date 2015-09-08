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
using System.Xml;
using System.IO;
using System.Net;


namespace IntegraDesigner.Resources.Properties
{
    /// <summary>
    /// Interaction logic for FILTERProperty.xaml
    /// </summary>
    public partial class includeProperty : UserControl
    {
        include g { get; set; }

        public includeProperty()
        {
            InitializeComponent();


        }

        public override string ToString()
        {
            g = (include)base.Tag;

            Binding myBinding = new Binding("context");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            cmbcontext.SetBinding(ComboBox.TextProperty, myBinding);

            return base.ToString();
        }
    }
     
}
