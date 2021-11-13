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

namespace Bai_9._5_Minh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, RoutedEventArgs e)
        {
            string order = "";
            if (cbxOrange.IsChecked == true)
                order = "Nước cam";
            if (cbxKiwi.IsChecked == true)
                order = order.Length == 0 ? "Nước kiwi" : order + ", nước kiwi";
            if (cbxMango.IsChecked == true)
                order = order.Length == 0 ? "Nước xoài" : order + ", nước xoài";
            if (cbxMilk.IsChecked == true)
                order = order.Length == 0 ? "Sữa tươi" : order + ", sữa tươi";
            if (cbxCafe.IsChecked == true)
                order = order.Length == 0 ? "Cafe" : order + ", cafe";
            
            MessageBox.Show("Bạn đã chọn " + order);
        }
    }
}
