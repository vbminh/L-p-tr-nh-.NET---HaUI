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

namespace Bai_9._4_Minh
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

        private void btCal_Click(object sender, RoutedEventArgs e)
        {
            double cscu, csmoi, skwdm, skwvdm, tong, skwtt;
            cscu = double.Parse(tbxOldValue.Text);
            csmoi = double.Parse(tbxNewValue.Text);
            if (csmoi < cscu)
                MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ");

            skwtt = csmoi - cscu;
            skwdm = skwtt >= 50 ? 50 : skwtt;
            skwvdm = skwtt < 50 ? 0 : skwtt - 50;
            tong = skwdm * 500 + skwvdm * 1000;

            tbxKw.Text = skwtt.ToString();
            tbxKwTDM.Text = skwdm.ToString();
            tbxKwVDM.Text = skwvdm.ToString();
            tbxTotal.Text = tong.ToString();
        }

        private void btPrint_Click(object sender, RoutedEventArgs e)
        {
            lbShow.Items.Add(cbxName.Text);
            lbShow.Items.Add("Số kw định mức: " + tbxKw.Text);
            lbShow.Items.Add("Tổng tiền: " + tbxTotal.Text);
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
