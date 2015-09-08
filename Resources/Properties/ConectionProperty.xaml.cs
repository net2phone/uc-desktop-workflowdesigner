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
    /// Interaction logic for ConectionProperty.xaml
    /// </summary>
    public partial class ConectionProperty : UserControl
    {
        private Connection MyConnection { get; set; }

        public ConectionProperty(Connection c)
        {
            MyConnection = c;
            InitializeComponent();
            Binding myBinding = new Binding("Label");
            myBinding.Mode = BindingMode.TwoWay;
            myBinding.Source = c;
            txtlabel.SetBinding(TextBox.TextProperty, myBinding);


            Binding myBinding2 = new Binding("DefaultPath");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = c;
            chkdefault.SetBinding(CheckBox.IsCheckedProperty, myBinding2);



            //Identificador de Caminos
            if (c.DefaultPath)
            {
                Shape s = MyConnection.Template.FindName("PART_ConnectionPath", MyConnection) as Shape;
                if (s != null)
                s.Stroke = Brushes.YellowGreen;
                Shape s1 = MyConnection.Template.FindName("PART_SinkAnchorPath", MyConnection) as Shape;
                if (s1 != null)
                s1.Stroke = Brushes.YellowGreen;

            }

            else
            {
                Shape s = MyConnection.Template.FindName("PART_ConnectionPath", MyConnection) as Shape;
                if (s != null)
                s.Stroke = Brushes.Tomato;

                Shape s1 = MyConnection.Template.FindName("PART_SinkAnchorPath", MyConnection) as Shape;
                if (s1 != null)
                s1.Stroke = Brushes.Tomato;

            }


                
           
        }

        private void chkdefault_Click(object sender, RoutedEventArgs e)
        {
            //Identificador de Caminos
            if (MyConnection.DefaultPath)
            {
                Shape s = MyConnection.Template.FindName("PART_ConnectionPath", MyConnection) as Shape;
                if ( s!= null)
                s.Stroke = Brushes.YellowGreen;
                Shape s1 = MyConnection.Template.FindName("PART_SinkAnchorPath", MyConnection) as Shape;
                if (s1 != null)
                s1.Stroke = Brushes.YellowGreen;



            }

            else
            {
                Shape s = MyConnection.Template.FindName("PART_ConnectionPath", MyConnection) as Shape;
                if (s != null)
                s.Stroke = Brushes.Tomato;
                Shape s1 = MyConnection.Template.FindName("PART_SinkAnchorPath", MyConnection) as Shape;
                if (s1 != null)
                s1.Stroke = Brushes.Tomato;

                
            }
        }
    }
}
