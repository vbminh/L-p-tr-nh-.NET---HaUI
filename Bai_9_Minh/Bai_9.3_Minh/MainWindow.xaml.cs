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

namespace Bai_9._3_Minh
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

        private void btInsert_Click(object sender, RoutedEventArgs e)
        {
            string name, sex, marital, hobby = "";

            lbxShow.Items.Clear();

            name = "Họ tên: " + tbxName.Text;
            sex = rbtFemale.IsChecked == true ? "Giới tính: Nữ" : "Giới tính: Nam";
            marital = rbtMarried.IsChecked == true ? "Tình trạng hôn nhân: Đã kết hôn" : "Tình trạng hôn nhân: Chưa kết hôn";
            if (cbxFootball.IsChecked == true)
                hobby = "Sở thích: Đá bóng";
            if (cbxMusic.IsChecked == true)
                hobby = hobby.Length == 0 ? "Sở thích: Âm nhạc" : hobby + ", Âm nhạc";
            if (cbxSwim.IsChecked == true)
                hobby = hobby.Length == 0 ? "Sở thích: Bơi lội" : hobby + ", Bơi lội";
            if (cbxClimb.IsChecked == true)
                hobby = hobby.Length == 0 ? "Sở thích: Leo núi" : hobby + ", Leo núi";

            lbxShow.Items.Add(name);
            lbxShow.Items.Add(sex);
            lbxShow.Items.Add(marital);
            lbxShow.Items.Add(hobby);
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
