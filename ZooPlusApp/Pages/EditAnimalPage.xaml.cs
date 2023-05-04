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
    /// Логика взаимодействия для EditAnimalPage.xaml
    /// </summary>
    public partial class EditAnimalPage : Page
    {
        Animal contextAnimal;
        public EditAnimalPage(Animal animal)
        {
            InitializeComponent();
            contextAnimal = animal;
            DataContext = contextAnimal;
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contextAnimal.Country) == true)
            {
                MessageBox.Show("Страна не заполнена");
                return;
            }
            if (string.IsNullOrWhiteSpace(contextAnimal.Habitat) == true)
            {
                MessageBox.Show("Ест. среда не заполнена");
                return;
            }
            if (string.IsNullOrWhiteSpace(contextAnimal.Nutrition) == true)
            {
                MessageBox.Show("Питание не заполнена");
                return;
            }
            if (contextAnimal.LifeTimeInYear < 0 || contextAnimal.LifeTimeInYear == null)
            {
                MessageBox.Show("Жизнь не заполнена");
                return;
            }

            App.DB.SaveChanges();
        }
    }
}
