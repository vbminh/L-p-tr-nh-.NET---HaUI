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
using Bai11._1_Minh.Models;

namespace Bai11._1_Minh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bai11_1Context db = new Bai11_1Context();
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayData();
            var queryCombo = from br in db.Brands
                             select br;
            cboBrandName.ItemsSource = queryCombo.ToList();
        }

        private void DisplayData()
        {
            var query = from sp in db.Products //truy vấn dữ liệu từ bảng Products
                        select sp;
            dgvSanPham.ItemsSource = query.ToList(); //hiển thị lên datagrid
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        { //tạo đối tượng Product muốn thêm
            Product pro = new Product();
            //Gán các thuộc tính
            pro.MaSp = txtID.Text;
            pro.TenSp = txtName.Text;
            pro.DonGia = double.Parse(txtPrice.Text);
            pro.Mau = txtColor.Text;
            //Lấy mã nhãn hiệu từ nhãn hiệu được chọn ở combobox
            var bra = (Brand)cboBrandName.SelectedItem;
            pro.MaHang = bra.MaHang;
            //Thêm đối tượng product mới
            db.Products.Add(pro);
            //Cập nhật thay đổi vào csdl
            db.SaveChanges();
            //Hiển thị lên datagrid
            DisplayData();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var query = from Sp in db.Products //Kiểm tra mã sp có tồn tại trong database k
                        where Sp.MaSp == txtID.Text
                        select Sp;
            Product spsua = query.FirstOrDefault(); //Trả về sản phẩm đầu tiên hoặc null
            spsua.TenSp = txtName.Text;
            spsua.DonGia = double.Parse(txtPrice.Text);
            spsua.Mau = txtColor.Text;

            Brand bra = (Brand)cboBrandName.SelectedItem; //Lấy ra nhãn hiệu được chọn
            spsua.MaHang = bra.MaHang;
            db.SaveChanges();
            DisplayData();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var query = from Sp in db.Products //Kiểm tra mã sp có tồn tại trong database k
                        where Sp.MaSp == txtID.Text
                        select Sp;
            Product proDel = query.FirstOrDefault();
            db.Products.Remove(proDel);
            db.SaveChanges();
            DisplayData();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
