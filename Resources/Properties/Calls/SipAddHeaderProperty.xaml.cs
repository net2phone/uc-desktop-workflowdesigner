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
using System.Text.RegularExpressions;

namespace IntegraDesigner.Resources.Properties
{
    /// <summary>
    /// Interaction logic for AnswerProperty.xaml
    /// </summary>
    public partial class SipAddHeaderProperty : UserControl
    {
        public SipAddHeader a { get; set; }
         
        public SipAddHeaderProperty()
        {
            InitializeComponent();
 

        }

        public override string  ToString()
        {
            a = (SipAddHeader)base.Tag;
            Binding myBinding = new Binding("header");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = a;
            txtdelay.SetBinding(TextBox.TextProperty, myBinding);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = a;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

 	         return base.ToString();
        }
        

       
    }
}
