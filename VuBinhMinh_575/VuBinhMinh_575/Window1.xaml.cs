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
using VuBinhMinh_575.Model; 

namespace VuBinhMinh_575
{
 
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NhanvienDBContext dbContext = new NhanvienDBContext();
            var query = from nv in dbContext.Nhanviens
                        select new
                        {
                            MaPhong = nv.MaPhong,
                            TongLuong = nv.Luong + (nv.Songaycong >= 27 ? (0.1 * nv.Luong) : 0)
                        };
            var query2 = from nv in query
                         group nv by nv.MaPhong into nvGroup
                         select new
                         {
                             MaPhong = nvGroup.Key,
                             TongLuong = nvGroup.Sum(nv => nv.TongLuong),
                             SLNV = nvGroup.Count()
                         };
            var query3 = from nv in query2
                         join phong in dbContext.PhongBans on nv.MaPhong equals phong.MaPhong
                         select new
                         {
                             MaPhong = nv.MaPhong,
                             TenPhong = phong.TenPhong,
                             SLNV = nv.SLNV,
                             TongLuong = nv.TongLuong,
                         };
            dgData.ItemsSource = query3.ToList();
            
        }
    }
}
