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
    /// Interaction logic for VoiceMailProperty.xaml
    /// </summary>
    public partial class VoiceMailProperty : UserControl
    {

        VoiceMail v { get; set; }
        public VoiceMailProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            v = (VoiceMail)base.Tag;

            Binding myBinding = new Binding("boxnumber");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = v;
            txtbox.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("context");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = v;
            txtcontext.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("flags");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = v;
            txtflags.SetBinding(TextBox.TextProperty, myBinding3);

            return base.ToString();
        }

    }
}
