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

namespace Bai_9._1_Minh
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

        private void btInsert_Click(object sender, RoutedEventArgs e)
        {
            string sachdachon, subsach;
            sachdachon = lbSach.SelectedItem.ToString();
            subsach = sachdachon.Substring(0,37) == "System.Windows.Controls.ListBoxItem: " ? sachdachon.Substring(37,sachdachon.Length-37) : sachdachon;
            LbShow.Items.Add(subsach);
        }

        private void btInsetAll_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < lbSach.Items.Count; i++)
            {
                string sachdachon, subsach;
                sachdachon = lbSach.Items[i].ToString();
                subsach = sachdachon.Substring(0, 37) == "System.Windows.Controls.ListBoxItem: " ? sachdachon.Substring(37, sachdachon.Length - 37) : sachdachon;
                LbShow.Items.Add(subsach);
            }
        }

        private void btReturnAll_Click(object sender, RoutedEventArgs e)
        {
            LbShow.Items.Clear();
        }

        private void btReturn_Click(object sender, RoutedEventArgs e)
        {
            LbShow.Items.Remove(LbShow.SelectedItem);
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
