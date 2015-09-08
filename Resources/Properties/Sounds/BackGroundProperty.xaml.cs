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
    /// Interaction logic for BackGroundProperty.xaml
    /// </summary>
    public partial class BackGroundProperty : UserControl
    {
        BackGround g { get; set; }

        public BackGroundProperty()
        {
            InitializeComponent();


        }

    

        public override string ToString()
        {
            g = (BackGround)base.Tag;

            Binding myBinding = new Binding("filename");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            cmbfilename.SetBinding(ComboBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("options");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtopt.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("langoverride");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = g;
            txtlang.SetBinding(ComboBox.TextProperty, myBinding3);


            Binding myBinding4 = new Binding("context");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = g;
            txtcontext.SetBinding(TextBox.TextProperty, myBinding4);


            return base.ToString();
        }
    }
}
