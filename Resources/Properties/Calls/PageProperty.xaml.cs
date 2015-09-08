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
    public partial class PageProperty : UserControl
    {
        public Page a { get; set; }
         
        public PageProperty()
        {
            InitializeComponent();
          
            
           

        }

        public override string  ToString()
        {
            a = (Page)base.Tag;
            Binding myBinding = new Binding("endpoints");
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
