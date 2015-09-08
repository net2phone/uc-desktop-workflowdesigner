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
    /// Interaction logic for CURLProperty.xaml
    /// </summary>
    public partial class CURLProperty : UserControl
    {
        CURL c { get; set; }

        public CURLProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            c = (CURL)base.Tag;

            Binding myBinding = new Binding("url");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = c;
            txturl.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("postdata");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = c;
            txtpost.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("variable");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = c;
            txtresult.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("isPost");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = c;
            chkpost.SetBinding(CheckBox.IsCheckedProperty, myBinding4);
        


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = c;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
