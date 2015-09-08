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
using System.Web;
using System.Xml;
using System.IO;

namespace IntegraDesigner.Resources.Properties
{
    /// <summary>
    /// Interaction logic for QueueProperty.xaml
    /// </summary>
    public partial class QueueProperty : UserControl
    {
        Queue q { get; set; }

        public QueueProperty()
        {
            InitializeComponent();
           
         

          
        }

     
     




        public override string ToString()
        {
            q = (Queue)base.Tag;

            Binding myBinding = new Binding("queuename");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = q;
            cmbqueues.SetBinding(ComboBox.TextProperty, myBinding);

            Binding myBinding3 = new Binding("options");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = q;
            txtopt.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding2 = new Binding("URL");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = q;
            txturl.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding4 = new Binding("announceoverride");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = q;
            txtannounce.SetBinding(TextBox.TextProperty, myBinding4);

            Binding myBinding5 = new Binding("timeout");
            myBinding5.Mode = BindingMode.TwoWay;
            myBinding5.Source = q;
            txttimeout.SetBinding(TextBox.TextProperty, myBinding5);

            Binding myBinding6 = new Binding("AGI");
            myBinding6.Mode = BindingMode.TwoWay;
            myBinding6.Source = q;
            txtagi.SetBinding(TextBox.TextProperty, myBinding6);

            Binding myBinding7 = new Binding("macro");
            myBinding7.Mode = BindingMode.TwoWay;
            myBinding7.Source = q;
            txtmacro.SetBinding(TextBox.TextProperty, myBinding7);

            Binding myBinding8 = new Binding("gosub");
            myBinding8.Mode = BindingMode.TwoWay;
            myBinding8.Source = q;
            txtgosub.SetBinding(TextBox.TextProperty, myBinding8);

            Binding myBinding9 = new Binding("rule");
            myBinding9.Mode = BindingMode.TwoWay;
            myBinding9.Source = q;
            txtrule.SetBinding(TextBox.TextProperty, myBinding9);


            Binding myBinding10 = new Binding("position");
            myBinding10.Mode = BindingMode.TwoWay;
            myBinding10.Source = q;
            txtpos.SetBinding(TextBox.TextProperty, myBinding10);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = q;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
