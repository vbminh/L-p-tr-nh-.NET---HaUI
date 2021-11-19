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
    /// Interaction logic for NhapMH.xaml
    /// </summary>
    public partial class NhapMH : Window
    {
        public NhapMH()
        {
            InitializeComponent();
        }

        private void btThemM_Click(object sender, RoutedEventArgs e)
        {
            string subID, subName, trinhdo;
            List<MonHoc> mh = new List<MonHoc>();

            subID = txtSubId.Text;
            if(subID.Length > 0)
            {
                    subName = txtSubName.Text;
                    if (subName.Length > 0)
                    {
                        trinhdo = cbxTrinhdo.Text;
                        if (trinhdo.Length > 0)
                        {
                            mh.Add(new MonHoc(subID, subName, trinhdo));
                            MessageBox.Show("Thêm thành công");

                        }
                        else
                        {
                            MessageBox.Show("Trình độ không được bỏ trống");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên môn học không được bỏ trống");
                    }
                }   
            else
            {
                MessageBox.Show("Mã môn học không được bỏ trống");
            }    
        }

        private void btXoaM_Click(object sender, RoutedEventArgs e)
        {
            txtSubId.Text = "";
            txtSubName.Text = "";
            cbxTrinhdo.SelectedIndex = -1;
        }

        private void btHuyM_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
