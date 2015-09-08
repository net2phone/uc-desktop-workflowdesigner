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
    /// Interaction logic for GotoProperty.xaml
    /// </summary>
    public partial class ChannelRedirectProperty : UserControl
    {
        ChannelRedirect g { get; set; }


        public ChannelRedirectProperty()
        {
            InitializeComponent();

        }

        public override string ToString()
        {
            g = (ChannelRedirect)base.Tag;


            Binding myBinding0 = new Binding("Channel");
            myBinding0.Mode = BindingMode.TwoWay;
            myBinding0.Source = g;
            txtchan.SetBinding(TextBox.TextProperty, myBinding0);


            Binding myBinding = new Binding("context");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            cmbcontext.SetBinding(ComboBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("extension");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtextension.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("pri");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = g;
            txtprio.SetBinding(TextBox.TextProperty, myBinding3);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }


    }
       
}
