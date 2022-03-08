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

namespace De5_Minh_575
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        string name, days, date, sex;
        public Window2()
        {
            InitializeComponent();
        }

        public Window2(string name, string days, string date, string sex)
        {
            InitializeComponent();
            this.name = name;
            this.days = days;
            this.date = date;
            this.sex = sex;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtName.Text = name;
            txtDays.Text = days;
            dpkDate.Text = date;
            if (sex == "Nam")
                rbtMale.IsChecked = true;
            else
                rbtFemale.IsChecked = true;
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
