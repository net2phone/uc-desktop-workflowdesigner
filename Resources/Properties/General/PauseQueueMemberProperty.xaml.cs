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
    /// Interaction logic for PauseQueueMemberProperty.xaml
    /// </summary>
    public partial class PauseQueueMemberProperty : UserControl
    {
        PauseQueueMember x { get; set; }
        public PauseQueueMemberProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            x = (PauseQueueMember)base.Tag;

            Binding myBinding = new Binding("queuename");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = x;
            txtevt.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("reason");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = x;
            txtbdy.SetBinding(TextBox.TextProperty, myBinding2);
           
            Binding myBinding3 = new Binding("interfac");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = x;
            txturl.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("options");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = x;
            txtapp.SetBinding(TextBox.TextProperty, myBinding4);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = x;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
