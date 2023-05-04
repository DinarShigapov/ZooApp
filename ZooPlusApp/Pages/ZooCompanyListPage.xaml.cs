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
using ZooPlusApp.Model;

namespace ZooPlusApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ZooCompanyListPage.xaml
    /// </summary>
    public partial class ZooCompanyListPage : Page
    {
        public ZooCompanyListPage()
        {
            InitializeComponent();
            DGZooList.ItemsSource = App.DB.ZooCompany.Where(x => x.IsDelete != true).ToList();
        }

        private void BDeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            var zooCompany = (sender as Button).DataContext as ZooCompany;
            if (zooCompany == null)
                return;

            zooCompany.IsDelete = true;
            App.DB.SaveChanges();
            DGZooList.ItemsSource = App.DB.ZooCompany.Where(x => x.IsDelete != true).ToList();
        }
    }
}
