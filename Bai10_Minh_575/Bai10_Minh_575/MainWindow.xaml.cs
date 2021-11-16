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

namespace Bai10_Minh_575
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string name, department, dateOfbirth, day, language = "";
        private int days, salary = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btInset_Click(object sender, RoutedEventArgs e)
        {
            name = tbxName.Text;
            if(name.Length == 0)
            {
                MessageBox.Show("Lỗi: Tên nhân viên không được bỏ trống");
            }
            else
            {
                department = cbxiOz.IsSelected == true ? "Tổ chức" : (cbxiSup.IsSelected == true ? "Vật tư" : (cbxiAcc.IsSelected == true ? "Tài chính" : (cbxiPlan.IsSelected == true? "Kế hoạch" : "")));
                if (department.Length == 0)
                {
                    MessageBox.Show("Lỗi: Phòng ban không được bỏ trống");
                }
                else
                {
                    if (cbxEnglish.IsChecked == true)
                        language = "- Anh";
                    if (cbxFrench.IsChecked == true)
                        language = language.Length == 0 ? "- Pháp" : language + ", Pháp";
                    if (cbxChinese.IsChecked == true)
                        language = language.Length == 0 ? "- Trung" : language + ", Trung";

                    dateOfbirth = dpkDate.Text;

                    if (dateOfbirth.Length == 0)
                    {
                        MessageBox.Show("Lỗi: Ngày sinh không được bỏ trống");
                    }
                    else
                    {
                        day = tbxDays.Text;
                        if(day.Length == 0)
                        {
                            MessageBox.Show("Lỗi: Số ngày làm việc không được bỏ trống");
                        }
                       else
                        {
                            days = int.Parse(tbxDays.Text);

                            if (days > 0)
                            {
                                salary = days > 20 ? (2000000 + (days - 20) * 200000) : days * 100000;

                                string str = name + " - " + department + language + " - " + dateOfbirth + " - " + salary;
                                lbxShow.Items.Add(str);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi: Số ngày làm việc phải lớn hơn 0");
                            }

                        }

                    }

                }

            }
 
        }

        private void btDel_Click(object sender, RoutedEventArgs e)
        {
            var today = DateTime.Today;

            tbxName.Text = "";
            tbxName.Focus();
            cbDepartment.SelectedIndex = -1;
            cbxEnglish.IsChecked = false;
            cbxFrench.IsChecked = false;
            cbxChinese.IsChecked = false;
            dpkDate.Text = today.ToString();
            tbxDays.Text = "";
            lbxShow.Items.Clear();
        }

        private void btWd2_Click(object sender, RoutedEventArgs e)
        {

            Window2 w2 = new Window2(this.name,this.department,this.language,this.dateOfbirth,this.day,this.salary.ToString());
           
            w2.ShowDialog();
        }
    }
}
