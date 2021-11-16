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

namespace Bai10_Minh_575
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private string name, depa, lang, date, days,salary;
        public Window2()
        {
            InitializeComponent();
        }

        public Window2(string name, string depa, string lang, string date, string days, string salary)
        {
            InitializeComponent();
            this.name = name;
            this.depa = depa;
            this.lang = lang;
            this.date = date;
            this.days = days;
            this.salary = salary;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtName.Text = name;
            cbDepartment.Text = depa;
            if (lang == "- Anh")
            {
                cbxEnglish.IsChecked = true;
            }
            if (lang == "-Anh, Pháp")
            {
                cbxEnglish.IsChecked = true;
                cbxFrench.IsChecked = true;
            }
            if (lang == "-Anh, Trung")
            {
                cbxEnglish.IsChecked = true;
                cbxChinese.IsChecked = true;
            }
            if (lang == "- Anh , Pháp, Trung")
            {
                cbxEnglish.IsChecked = true;
                cbxFrench.IsChecked = true;
                cbxChinese.IsChecked = true;
            }
            if (lang == "- Pháp")
                cbxFrench.IsChecked = true;
            if(lang == "- Pháp, Trung")
            {
                cbxFrench.IsChecked = true;
                cbxChinese.IsChecked = true;
            }    
            if (lang.Contains("- Trung"))
                cbxChinese.IsChecked = true;

            dpkDate.Text = date;
            tbxDays.Text = days;
            tbxSalary.Text = salary;
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
