﻿using System;
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
using System.Xml;
using System.IO;
using System.Net;

namespace IntegraDesigner.Resources.Properties
{
    /// <summary>
    /// Interaction logic for GotoIfTimeProperty.xaml
    /// </summary>
    public partial class GotoIfTimeProperty : UserControl
    {
        GotoIfTime g { get; set; }

        public GotoIfTimeProperty()
        {
            InitializeComponent();

        }

        public override string ToString()
        {
            g = (GotoIfTime)base.Tag;

            Binding myBinding = new Binding("timerange");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtrange.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("daysofweek");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtdaysw.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("daysofmonth");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = g;
            txtdaysm.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("months");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = g;
            txtmonth.SetBinding(TextBox.TextProperty, myBinding4);

            Binding myBinding5 = new Binding("context");
            myBinding5.Mode = BindingMode.TwoWay;
            myBinding5.Source = g;
            cmbcontext.SetBinding(ComboBox.TextProperty, myBinding5);

            Binding myBinding6 = new Binding("extension");
            myBinding6.Mode = BindingMode.TwoWay;
            myBinding6.Source = g;
            txtext.SetBinding(TextBox.TextProperty, myBinding6);

            Binding myBinding7 = new Binding("pri");
            myBinding7.Mode = BindingMode.TwoWay;
            myBinding7.Source = g;
            txtprio.SetBinding(TextBox.TextProperty, myBinding7);

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }

       

    }
}
