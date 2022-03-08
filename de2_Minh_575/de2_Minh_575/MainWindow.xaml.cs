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
using De2_Minh_575.Models;

namespace De2_Minh_575
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLyBanHangContext db = new QLyBanHangContext();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            var query = from kh in db.KhachHangs
                        select kh;
            dgvShow.ItemsSource = query.ToList();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            KhachHang khThem = new KhachHang();

            khThem.MaKh = txtID.Text;
            khThem.NgayMua = dpkDate.SelectedDate;
            khThem.SoLuongMua = int.Parse(txtNum.Text);
            khThem.DonGia = double.Parse(txtPrice.Text);

            db.KhachHangs.Add(khThem);
            db.SaveChanges();
            DisplayData(); 
        }

    }
}
