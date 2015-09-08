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
    /// Interaction logic for STATProperty.xaml
    /// </summary>
    public partial class STATProperty : UserControl
    {
        STAT s { get; set; }

        public STATProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            s = (STAT)base.Tag;

            Binding myBinding2 = new Binding("result");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = s;
            txtres.SetBinding(TextBox.TextProperty, myBinding2);


            Binding myBinding = new Binding("flag");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = s;
            txtflag.SetBinding(ComboBox.TextProperty, myBinding);

            Binding myBinding3 = new Binding("filename");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = s;
            txtpath.SetBinding(TextBox.TextProperty, myBinding3);
            
            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
