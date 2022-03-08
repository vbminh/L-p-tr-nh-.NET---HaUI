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
using VuBinhMinh_575.Model;

namespace VuBinhMinh_575
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NhanvienDBContext dbContext = new NhanvienDBContext();
        public MainWindow()
        {
            InitializeComponent();
            
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiCbxPhong();
            HienThiDuLieu();
        }
        private void HienThiCbxPhong()
        {
            var query = from phong in dbContext.PhongBans
                        select phong;
            cbxPhong.ItemsSource = query.ToList();
            cbxPhong.DisplayMemberPath = "TenPhong";
            cbxPhong.SelectedValuePath = "MaPhong";
            cbxPhong.SelectedIndex = 0;
        }

        private void HienThiDuLieu()
        {
            var query = from nv in dbContext.Nhanviens
                        orderby nv.Songaycong
                        where nv.Songaycong >= 25
                        select new
                        {
                            MaPhong = nv.MaPhong,
                            MaNV = nv.MaNv,
                            Hoten = nv.Hoten,
                            Songaycong = nv.Songaycong,
                            Luong = nv.Luong,
                            Thuong = nv.Songaycong >= 27 ? (0.1 * nv.Luong) : 0
                        };
            dgData.ItemsSource = query.ToList();
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMa.Text) == true || string.IsNullOrEmpty(txtTen.Text) == true || string.IsNullOrEmpty(txtLuong.Text) == true || string.IsNullOrEmpty(txtNgCong.Text) == true || cbxPhong.SelectedIndex < 0)
                {
                    MessageBox.Show("Cần nhập đủ các trường dữ liệu", "Lỗi");
                }
                else
                {
                    if (int.Parse(txtNgCong.Text) < 20 || int.Parse(txtNgCong.Text) > 30)
                    {
                        MessageBox.Show("Số ngày công từ 20 đến 30", "Lỗi");
                    }
                    else if (int.Parse(txtLuong.Text) < 3000 || int.Parse(txtLuong.Text) > 9000)
                    {
                        MessageBox.Show("Lương từ 3000 đến 9000", "Lỗi");
                    }
                    else
                    {
                        if (dbContext.Nhanviens.SingleOrDefault(sp => sp.MaNv == int.Parse(txtMa.Text)) != null)
                        {
                            MessageBox.Show("Đã tồn tại mã nhân viên", "Lỗi");
                        }
                        else
                        {
                            Nhanvien newNV = new Nhanvien();
                            newNV.MaNv = int.Parse(txtMa.Text);
                            newNV.Hoten = txtTen.Text;
                            newNV.Luong = int.Parse(txtLuong.Text);
                            newNV.Songaycong = int.Parse(txtNgCong.Text);
                            newNV.MaPhong = ((PhongBan)cbxPhong.SelectedItem).MaPhong;
                            dbContext.Nhanviens.Add(newNV);
                            dbContext.SaveChanges();
                            HienThiDuLieu();
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lương và Số ngày công là số nguyên dương", "Lỗi");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi gì đó", "Lỗi");
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMa.Text) == true || string.IsNullOrEmpty(txtTen.Text) == true || string.IsNullOrEmpty(txtLuong.Text) == true || string.IsNullOrEmpty(txtNgCong.Text) == true || cbxPhong.SelectedIndex < 0)
                {
                    MessageBox.Show("Cần nhập đủ các trường dữ liệu", "Lỗi");
                }
                else
                {
                    if (int.Parse(txtNgCong.Text) < 20 || int.Parse(txtNgCong.Text) > 30)
                    {
                        MessageBox.Show("Số ngày công từ 20 đến 30", "Lỗi");
                    }
                    else if (int.Parse(txtLuong.Text) < 3000 || int.Parse(txtLuong.Text) > 9000)
                    {
                        MessageBox.Show("Lương từ 3000 đến 9000", "Lỗi");
                    }
                    else
                    {
                        var nvSua = dbContext.Nhanviens.SingleOrDefault(sp => sp.MaNv == int.Parse(txtMa.Text));
                        if (nvSua == null)
                        {
                            MessageBox.Show("Không tồn tại mã sản phẩm", "Lỗi");
                        }
                        else
                        {
                            nvSua.Hoten = txtTen.Text;
                            nvSua.Luong = int.Parse(txtLuong.Text);
                            nvSua.Songaycong = int.Parse(txtNgCong.Text);
                            nvSua.MaPhong = ((PhongBan)cbxPhong.SelectedItem).MaPhong;
                            dbContext.SaveChanges();
                            HienThiDuLieu();
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lương và Số ngày công là số nguyên dương", "Lỗi");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi gì đó", "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (dgData.SelectedItem != null)
            {
                MessageBoxResult messageBoxResult = MessageBox.Show("Bạn chắc chắn muốn xoá?", "Thông báo", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    var nvXoa = dbContext.Nhanviens.SingleOrDefault(sp => sp.MaNv == int.Parse(txtMa.Text));
                    dbContext.Nhanviens.Remove(nvXoa);
                    dbContext.SaveChanges();
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 nhân viên trong danh sách trước khi xoá");
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            win.Show();
        }

        
        /*
         *
         */

        /*
         *  private void dgData_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dgData.SelectedItem != null)
            {
                Type type = dgData.SelectedItem.GetType();
                PropertyInfo[] infos = type.GetProperties();
                cbMaPhong.SelectedValue = infos[0].GetValue(dgData.SelectedItem).ToString();
                txtMaNV.Text = infos[1].GetValue(dgData.SelectedItem).ToString();
                txtHoTen.Text = infos[2].GetValue(dgData.SelectedItem).ToString();
                txtLuong.Text = infos[3].GetValue(dgData.SelectedItem).ToString();
                txtThuong.Text = infos[4].GetValue(dgData.SelectedItem).ToString();
            }
        }
        
        /*
         *  private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            
        }
         */

        /*
         * private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            
        }
         */
    }
}
