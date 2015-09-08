using System.Windows;
using System.Windows.Controls;
using System.Xml;
using System;
using System.Net.NetworkInformation;
using System.Collections.Generic;

namespace IntegraDesigner
{
    public partial class Window1 : Window
    {
        public static StackPanel Props;

        public Window1()
        {
            InitializeComponent();
            Props = this.MyProperties;
        }


       

      

        private void Window_Closed(object sender, System.EventArgs e)
        {
           
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
