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
using Bai12._1_Minh.Models;

namespace Bai12._1_Minh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bai11_2_QLBanHangContext db = new Bai11_2_QLBanHangContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                    string.IsNullOrWhiteSpace(txtPw.Password))
                {
                    throw new Exception("Tên đăng nhập hoặc mật khẩu không được để trống!!");
                }

                var querySize = (from account in db.NguoiDungs
                                 where account.TenDangNhap.Equals(txtUserName.Text)
                                 && account.Matkhau.Equals(txtPw.Password)
                                 select account).ToList().Count;

                if (querySize == 1)
                {
                    QuanLyBanHang window = new QuanLyBanHang();
                    window.txtUsername.Text = txtUserName.Text;

                    MessageBox.Show("Đăng Nhập Thành Công!!!", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);

                    window.Show();
                    Close();
                }
                else
                {
                    throw new Exception("Đăng Nhập Không Thành Công!!!!\n\nMật Khẩu Hoặc Tài Khoản Của Bạn Sai!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
