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

namespace IntegraDesigner.Resources.Properties
{
    /// <summary>
    /// Interaction logic for MonitorProperty.xaml
    /// </summary>
    public partial class MonitorProperty : UserControl
    {
        Monitor g { get; set; }


        public MonitorProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (Monitor)base.Tag;

            Binding myBinding = new Binding("ext");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtext.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("basename");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtbase.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("flags");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = g;
            txtflags.SetBinding(TextBox.TextProperty, myBinding3);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
