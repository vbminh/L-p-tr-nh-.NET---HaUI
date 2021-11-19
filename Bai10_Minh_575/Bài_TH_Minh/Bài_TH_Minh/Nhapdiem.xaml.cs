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
    /// Interaction logic for Nhapdiem.xaml
    /// </summary>
    public partial class Nhapdiem : Window
    {
        public Nhapdiem()
        {
            InitializeComponent();
        }

        private void btThemD_Click(object sender, RoutedEventArgs e)
        {
            string masv;
            double diemlt, diemth, diemut;
            List<Diem> diem = new List<Diem>();

            masv = txtStuID.Text;
            if (masv.Length > 0)
            {
                diemlt = double.Parse(txtLT.Text);
                if(diemlt >= 0 && diemlt <= 10) 
                {
                    diemth = double.Parse(txtTH.Text);
                    if (diemth >= 0 && diemth <= 10)
                    {
                        diemut = double.Parse(txtUT.Text);
                        if(diemut <= 0 && diemut > 2)
                            MessageBox.Show("Điểm ưu tiên không hợp lệ");
                        else
                        {
                            diem.Add(new Diem(masv, diemlt, diemth, diemut));
                            MessageBox.Show("Thêm thành công");
                        }
                    }
                    else
                        MessageBox.Show("Điểm thực hành không hợp lệ");
                }
                else
                    MessageBox.Show("Điểm lý thuyết không hợp lệ");
            }
            else
                MessageBox.Show("Mã sinh viên không được bỏ trống");
        }

        private void btXoaX_Click(object sender, RoutedEventArgs e)
        {
            txtStuID.Text = "";
            txtLT.Text = "";
            txtTH.Text = "";
            txtUT.Text = "";
        }

        private void btHuyD_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
