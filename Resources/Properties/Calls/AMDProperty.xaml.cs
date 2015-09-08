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
    /// Interaction logic for AMDProperty.xaml
    /// </summary>
    public partial class AMDProperty : UserControl
    {
        AMD r { get; set; }

        public AMDProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            r = (AMD)base.Tag;
            
            Binding myBinding = new Binding("initialSilence");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = r;
            txtsilence.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("greeting");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = r;
            txtgreeting.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("afterGreetingSilence");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = r;
            txtafter.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("totalAnalysisTime");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = r;
            txtanalisis.SetBinding(TextBox.TextProperty, myBinding4);

            Binding myBinding5 = new Binding("minWordLength");
            myBinding5.Mode = BindingMode.TwoWay;
            myBinding5.Source = r;
            txtmin.SetBinding(TextBox.TextProperty, myBinding5);

            Binding myBinding6 = new Binding("betweenWordsSilence");
            myBinding6.Mode = BindingMode.TwoWay;
            myBinding6.Source = r;
            txtbet.SetBinding(TextBox.TextProperty, myBinding6);

            Binding myBinding7 = new Binding("maxNumberOfWords");
            myBinding7.Mode = BindingMode.TwoWay;
            myBinding7.Source = r;
            txtmax.SetBinding(TextBox.TextProperty, myBinding7);

            Binding myBinding8 = new Binding("silenceThreshold");
            myBinding8.Mode = BindingMode.TwoWay;
            myBinding8.Source = r;
            txtsil.SetBinding(TextBox.TextProperty, myBinding8);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = r;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
