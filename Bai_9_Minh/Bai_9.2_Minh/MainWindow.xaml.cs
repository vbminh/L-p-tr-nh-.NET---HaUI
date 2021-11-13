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

namespace Bai_9._2_Minh
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
            string show, name, sex, position;
            name = tbxName.Text;
            sex = cbxGirl.IsSelected == true ? "Nữ" : "Nam";
            position = cbxAccounting.IsSelected == true ? "Phòng tài chính" : (cbxBusiness.IsSelected == true ? "Phòng kinh doanh" : "Phòng kĩ thuật");

            show = name + " - " + sex + " - " + position;
            lbxShow.Items.Add(show);

            tbxName.Text = "";
            cbxBoy.IsSelected = true;
            cbxTechnical.IsSelected = true;
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
