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

namespace Bài_TH_Minh
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

        private void mnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sel2_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Welcome to my Window");
        }

        private void Sel2_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I'm very glad if you give me your comment");
        }

        private void Sel1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("There is a demo Window");
        }

        private void SuCon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Made by Binh Minh");
        }

        private void btUser_Click(object sender, RoutedEventArgs e)
        {
            NhapSV nhapsv = new NhapSV();
            nhapsv.ShowDialog();
        }

        private void btKhoa_Click(object sender, RoutedEventArgs e)
        {
            NhapKhoa nhapkhoa = new NhapKhoa();
            nhapkhoa.ShowDialog();
        }

        private void btSub_Click(object sender, RoutedEventArgs e)
        {
            NhapMH nhapmh = new NhapMH();
            nhapmh.ShowDialog();
        }

        private void btMark_Click(object sender, RoutedEventArgs e)
        {
            Nhapdiem diem = new Nhapdiem();
            diem.ShowDialog();
        }

        private void btSee_Click(object sender, RoutedEventArgs e)
        {
            Xem_điểm xem = new Xem_điểm();
            xem.ShowDialog();
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btThongke_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
