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
    /// Interaction logic for RecordProperty.xaml
    /// </summary>
    public partial class ControlPlaybackProperty : UserControl
    {
        ControlPlayback g { get; set; }

        public ControlPlaybackProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (ControlPlayback)base.Tag;

            Binding myBinding = new Binding("filename");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtfile.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("skipms");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtskipms.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("ff");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = g;
            txtff.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("rew");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = g;
            txtrew.SetBinding(TextBox.TextProperty, myBinding4);

            Binding myBinding5 = new Binding("stop");
            myBinding5.Mode = BindingMode.TwoWay;
            myBinding5.Source = g;
            txtstop.SetBinding(TextBox.TextProperty, myBinding5);

            Binding myBinding6 = new Binding("pause");
            myBinding6.Mode = BindingMode.TwoWay;
            myBinding6.Source = g;
            txtpause.SetBinding(TextBox.TextProperty, myBinding6);

            Binding myBinding7 = new Binding("restart");
            myBinding7.Mode = BindingMode.TwoWay;
            myBinding7.Source = g;
            txtrestart.SetBinding(TextBox.TextProperty, myBinding7);

            Binding myBinding8 = new Binding("options");
            myBinding8.Mode = BindingMode.TwoWay;
            myBinding8.Source = g;
            txtopt.SetBinding(TextBox.TextProperty, myBinding8);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
