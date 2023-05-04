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
    /// Логика взаимодействия для AnimalsListPage.xaml
    /// </summary>
    public partial class AnimalsListPage : Page
    {
        public AnimalsListPage()
        {
            InitializeComponent();
            CBSorting.SelectedIndex = 0;
            RefreshAnimalList();
        }

        private void RefreshAnimalList()
        {
            IEnumerable<Animal> animalsFilter = App.DB.Animal.Where(x => x.IsDelete != true).ToList();

            if (CBSorting.SelectedIndex == 1)
                animalsFilter = animalsFilter.OrderBy(x => x.LifeTimeInYear);
            else if (CBSorting.SelectedIndex == 2)
                animalsFilter = animalsFilter.OrderByDescending(x => x.LifeTimeInYear);

            if (TBSearch.Text.Length > 0)
            {
                animalsFilter = animalsFilter.Where(x => x.Country.ToLower().StartsWith(TBSearch.Text.ToLower()));
            }

            LVAnimalsList.ItemsSource = animalsFilter;
        }

        private void TBSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            RefreshAnimalList();
        }

        private void CBSorting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshAnimalList();
        }

        private void BEditAnimal_Click(object sender, RoutedEventArgs e)
        {
            var animalEdit = (sender as Button).DataContext as Animal;
            if(animalEdit == null)
                return;
            NavigationService.Navigate(new EditAnimalPage(animalEdit));
        }
    }
}
