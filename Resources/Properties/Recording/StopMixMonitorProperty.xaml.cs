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
    /// Interaction logic for StopMixMonitorProperty.xaml
    /// </summary>
    public partial class StopMixMonitorProperty : UserControl
    {

        StopMixMonitor g { get; set; }
        
        public StopMixMonitorProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (StopMixMonitor)base.Tag;

            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);


            return base.ToString();
        }
    }
}
