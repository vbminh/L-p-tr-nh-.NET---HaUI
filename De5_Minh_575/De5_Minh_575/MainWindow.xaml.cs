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

namespace De5_Minh_575
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

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            string hoten, gioitinh;
            double songaylamviec, tienluong;
            DateTime? ngaytuyendung;

            hoten = txtName.Text;
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtDays.Text) || string.IsNullOrEmpty(dpkDate.Text))
            {
                
                MessageBox.Show("Bạn phải điền đủ các trường");
            }
            else
            {
                songaylamviec = double.Parse(txtDays.Text);
                if (songaylamviec > 0)
                {
                    ngaytuyendung = dpkDate.SelectedDate;
                    if (ngaytuyendung.Value <= DateTime.Today)
                    {
                        gioitinh = rbtFemale.IsChecked == true ? "Nữ" : "Nam";
                        if (songaylamviec > 10)
                            tienluong = 2000000 + (songaylamviec - 10) * 400000;
                        else
                            tienluong = songaylamviec * 200000;

                        string item = hoten + " - " + dpkDate.Text + " - " + gioitinh + " - Số ngày làm việc: " + songaylamviec + " - Tiền lương: " + tienluong;
                        lbxDisplay.Items.Add(item);
                    }
                    else MessageBox.Show("Ngày tuyển dụng phải là ngày hiện tại hoặc trước ngày hiện tại");

                }
                else MessageBox.Show("Số ngày làm việc phải lớn hơn 0");
            }
        }

        private void btDel_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
            txtDays.Text = "";
            rbtMale.IsChecked = true;
            var today = DateTime.Today;
            dpkDate.Text = today.ToString();
            lbxDisplay.Items.Clear();
            txtName.Focus();
        }

        private void btWin2_Click(object sender, RoutedEventArgs e)
        {
            string gioitinh = rbtFemale.IsChecked == true ? "Nữ" : "Nam";
            Window2 w2 = new Window2(txtName.Text, txtDays.Text, dpkDate.Text, gioitinh);
            w2.Show();
        }
    }
}
