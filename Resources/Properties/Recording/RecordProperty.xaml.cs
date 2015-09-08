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
    /// Interaction logic for RecordProperty.xaml
    /// </summary>
    public partial class RecordProperty : UserControl
    {
        Record g { get; set; }

        public RecordProperty()
        {
            InitializeComponent();
        }

        public override string ToString()
        {
            g = (Record)base.Tag;

            Binding myBinding = new Binding("filename");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = g;
            txtfile.SetBinding(TextBox.TextProperty, myBinding);

            Binding myBinding2 = new Binding("format");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = g;
            txtformat.SetBinding(TextBox.TextProperty, myBinding2);

            Binding myBinding3 = new Binding("silence");
            myBinding3.Mode = BindingMode.TwoWay;
            myBinding3.Source = g;
            txtsilence.SetBinding(TextBox.TextProperty, myBinding3);

            Binding myBinding4 = new Binding("maxduration");
            myBinding4.Mode = BindingMode.TwoWay;
            myBinding4.Source = g;
            txtmax.SetBinding(TextBox.TextProperty, myBinding4);

            Binding myBinding5 = new Binding("option");
            myBinding5.Mode = BindingMode.TwoWay;
            myBinding5.Source = g;
            txtopt.SetBinding(TextBox.TextProperty, myBinding5);


            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = g;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
