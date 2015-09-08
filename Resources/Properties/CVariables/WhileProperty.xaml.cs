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
    /// Interaction logic for WhileProperty.xaml
    /// </summary>
    public partial class WhileProperty : UserControl
    {
        While w { get; set; }

        public WhileProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            w = (While)base.Tag;

            Binding myBinding = new Binding("condition");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = w;
            txtcond.SetBinding(TextBox.TextProperty, myBinding);



            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = w;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
