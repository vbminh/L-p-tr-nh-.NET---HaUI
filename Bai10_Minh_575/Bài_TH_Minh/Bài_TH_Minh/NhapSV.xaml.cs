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
using System.Windows.Shapes;

namespace Bài_TH_Minh
{
    /// <summary>
    /// Interaction logic for NhapSV.xaml
    /// </summary>
    public partial class NhapSV : Window
    {
        public NhapSV()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, RoutedEventArgs e)
        {
            string stuID, stuName, stuSex, stuAddress;
            List<SinhVien> sv = new List<SinhVien>();

            stuID = txtID.Text;
            if(stuID.Length > 0)
            {
                stuName = txtName.Text;
                if(stuName.Length > 0)
                {
                    stuSex = rbtNam.IsChecked == true ? "Nam" : "Nữ";

                    stuAddress = txtAddress.Text;
                    if(stuAddress.Length > 0)
                    {
                        sv.Add(new SinhVien(stuID, stuName, stuSex, stuAddress));
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    { 
                        MessageBox.Show("Địa chỉ không được bỏ trống");
                    }
                }
                else
                {
                    MessageBox.Show("Tên sinh viên không được bỏ trống");
                }
            }
            else
            {
                MessageBox.Show("Mã sinh viên không được bỏ trống");
            }
          
        }

        private void btDel_Click(object sender, RoutedEventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            rbtNam.IsChecked = true;
            txtID.Focus();
        }

        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
