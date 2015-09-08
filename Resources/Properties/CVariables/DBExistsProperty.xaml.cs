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
    /// Interaction logic for SetProperty.xaml
    /// </summary>
    public partial class DBExistsProperty : UserControl
    {
        DBExists g { get; set; }

        public DBExistsProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (DBExists)base.Tag;

            Binding myBinding = new Binding("family");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtfam.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("key");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtkey.SetBinding(TextBox.TextProperty, myBinding2);


            Binding myBinding3 = new Binding("varname");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = g;
            txtval.SetBinding(TextBox.TextProperty, myBinding3);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
