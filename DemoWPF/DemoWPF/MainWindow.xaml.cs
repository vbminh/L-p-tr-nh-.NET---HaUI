using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoWPF
{
 
    public partial class MainWindow : Window
    {
        Button button;
        public MainWindow()
        {
            InitializeComponent();

            button = new Button();
            button.Content = "Click here";
            button.LayoutTransform = new ScaleTransform(3, 3);
            button.Background = Brushes.Red;
            button.MouseMove += Button_MouseMove;
            button.Margin = new Thickness(10);
            button.Click += new RoutedEventHandler(Button_Click);

            this.Content = button;
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            button.Background = Brushes.Green;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button.Content = "Hi Minh";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
