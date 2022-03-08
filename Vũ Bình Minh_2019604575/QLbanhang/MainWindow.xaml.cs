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
using QLbanhang.Models;


namespace QLbanhang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    
    public partial class MainWindow : Window
    {
        QLBanHangContext db = new QLBanHangContext();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDuLieu();
            // truy van du lieu tu bang san pham
            var queryCombo = from lsp in db.LoaiSps
                             select lsp;
            cboLoai.ItemsSource = queryCombo.ToList();
        }
        private void HienThiDuLieu()
        {
            // Truy van du lieu tu bang san pham
            var query = from sp in db.SanPhams
                        select sp;
            //hien thi du lieu len data grid
            dgvSanPham.ItemsSource = query.ToList();

        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            // Tao 1 san pham moi
            SanPham sanPhamMoi = new SanPham();
            sanPhamMoi.MaSp = txtMa.Text;
            sanPhamMoi.TenSp = txtTen.Text;
            LoaiSp lspChon = (LoaiSp)cboLoai.SelectedItem;// lay ra loai san pham duoc con
            sanPhamMoi.MaLoai = lspChon.MaLoai;
            sanPhamMoi.SoLuongCo = Convert.ToInt32(txtSoLuongCo.Text);
            sanPhamMoi.DonGia = Convert.ToInt32(txtDonGia.Text);
            // them san pham vao db
            db.SanPhams.Add(sanPhamMoi);
            // cap nhat co so dulieu
            db.SaveChanges();
            // hien thi lai du lieu
            HienThiDuLieu();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        where sp.MaSp == txtMa.Text
                        select sp;
            SanPham spSua = query.FirstOrDefault();
            // lay ra thong tin
            spSua.TenSp = txtTen.Text;
            spSua.DonGia = Convert.ToInt32(txtDonGia.Text);
            spSua.SoLuongCo = Convert.ToInt32(txtSoLuongCo.Text);
            LoaiSp lspChon = (LoaiSp)cboLoai.SelectedItem;// lay ra loai san pham duoc con
            spSua.MaLoai = lspChon.MaLoai;
            db.SaveChanges();
            HienThiDuLieu();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        where sp.MaSp == txtMa.Text
                        select sp;
            SanPham spXoa = query.FirstOrDefault();

            db.SanPhams.Remove(spXoa);
            db.SaveChanges();
            HienThiDuLieu();
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        where sp.DonGia >= 1000
                        select sp;
            dgvSanPham.ItemsSource = query.ToList();
        }
    }
}
