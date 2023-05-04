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
using ZooPlusApp.Pages;

namespace ZooPlusApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameMainWindow.Navigate(new AnimalsListPage());
        }

        private void BShowAnimalsList_Click(object sender, RoutedEventArgs e)
        {
            FrameMainWindow.Navigate(new AnimalsListPage());
        }

        private void BShowZooList_Click(object sender, RoutedEventArgs e)
        {
            FrameMainWindow.Navigate(new ZooCompanyListPage());
        }
    }
}
