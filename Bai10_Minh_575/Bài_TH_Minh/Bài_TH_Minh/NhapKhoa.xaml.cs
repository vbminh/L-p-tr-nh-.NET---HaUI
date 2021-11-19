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
    /// Interaction logic for NhapKhoa.xaml
    /// </summary>
    public partial class NhapKhoa : Window
    {
        public NhapKhoa()
        {
            InitializeComponent();
        }

        private void btHuyK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btXoaK_Click(object sender, RoutedEventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtTKhoa.Text = "";
            txtVPhong.Text = "";
        }

        private void btThemK_Click(object sender, RoutedEventArgs e)
        {
            string khoaID, khoaName, truongkhoa, vanphong;
            List<Khoa> khoa = new List<Khoa>();

            khoaID = txtID.Text;
            if (khoaID.Length > 0)
            {
                khoaName = txtName.Text;
                if(khoaName.Length > 0)
                {
                    truongkhoa = txtTKhoa.Text;
                    if(truongkhoa.Length > 0)
                    {
                        vanphong = txtVPhong.Text;
                        if(vanphong.Length > 0)
                        {
                            khoa.Add(new Khoa(khoaID, khoaName, truongkhoa, vanphong));
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                            MessageBox.Show("Địa chỉ văn phòng khoa không được bỏ trống");
                    }
                    else
                        MessageBox.Show("Tên trưởng khoa không được bỏ trống");
                }
                else
                    MessageBox.Show("Tên khoa không được bỏ trống");
            }
            else
                MessageBox.Show("Mã khoa không được bỏ trống");
        }
    }
}
