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
    /// Interaction logic for Xem_điểm.xaml
    /// </summary>
    public partial class Xem_điểm : Window
    {
        public Xem_điểm()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            string masv, monhoc;
            masv = txtStuID.Text;
            monhoc = txtSubID.Text;

            
        }
    }
}
