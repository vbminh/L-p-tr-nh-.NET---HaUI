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
using Bai11._3_Minh.Models;

namespace Bai11._3_Minh
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayData();
            var query = from lsp in db.LoaiSanPhams
                        select lsp;
            cbxBrandID.ItemsSource = query.ToList();
            
        }

        private void DisplayData()
        {
            var query = from sp in db.SanPhams //lấy dữ liệu bảng sp từ database
                        join lsp in db.LoaiSanPhams
                        on sp.MaLoai equals lsp.MaLoai
                        select new {
                            MaSp = sp.MaSp,
                            TenSp = sp.TenSp,
                            SoLuong = sp.SoLuong,
                            DonGia = sp.DonGia,
                            TenLoai = lsp.TenLoai };
            dgvDisplay.ItemsSource = query.ToList();
           
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            SanPham spmoi = new SanPham(); //tạo sp mới
            spmoi.MaSp = txtID.Text;
            spmoi.TenSp = txtName.Text;
            spmoi.SoLuong = int.Parse(txtNum.Text);
            spmoi.DonGia = int.Parse(txtPrice.Text);
            var lsp = (LoaiSanPham)cbxBrandID.SelectedItem; //lấy ra id của loại sp được chọn
            spmoi.MaLoai = lsp.MaLoai;

            db.SanPhams.Add(spmoi); //thêm sp mới vào database
            db.SaveChanges(); //lưu lại thay đổi
            DisplayData(); //hiển thị dl
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        where sp.MaSp == txtID.Text
                        select sp;
            SanPham spxoa = query.FirstOrDefault(); //trả về sp đầu thỏa mãn or null
            db.SanPhams.Remove(spxoa); //xóa sp
            var query1 = from sp in db.HoaDonChiTiets
                        where sp.MaSp == txtID.Text
                        select sp;
            HoaDonChiTiet spxoa1 = query1.FirstOrDefault();
            db.HoaDonChiTiets.Remove(spxoa1);
            db.SaveChanges(); //lưu lại thay đổi
            DisplayData(); //hiển thị dl
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        where sp.MaSp == txtID.Text
                        select sp;
            SanPham spsua = query.FirstOrDefault(); //trả về sp đầu thỏa mãn or null
            spsua.TenSp = txtName.Text;
            spsua.SoLuong = int.Parse(txtNum.Text);
            spsua.DonGia = int.Parse(txtPrice.Text);
            var maloai = (LoaiSanPham)cbxBrandID.SelectedItem;
            spsua.MaLoai = maloai.MaLoai;
            db.SaveChanges(); //lưu lại thay đổi
            DisplayData(); //hiển thị dl
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
