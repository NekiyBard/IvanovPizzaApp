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

namespace PizzaApp
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        private double price = 0;
        private double finalPrice = 0;
        private string[] pizzas =
        {
            "Маргарита",
            "4 сыра",
            "Пепперони",
            "Песто",
            "Гавайская"
        };
        public MenuPage()
        {
            InitializeComponent();
            for(int i=0; i < pizzas.Length; i++)
            {
                PizzaListBox.Items.Add(pizzas[i]);
            }
            PriceTextBlock.Text = "Итоговая Стоимость: " + price;
        }

        private void pizzaList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (PizzaListBox.SelectedIndex)
            {
                case 0: CountTextBlock.Text = "Цена: 300 рублей";
                    price = 300;
                    break;
                case 1:
                    CountTextBlock.Text = "Цена: 450 рублей";
                    price = 450;
                    break;
                case 2:
                    CountTextBlock.Text = "Цена: 500 рублей";
                    price = 500;
                    break;
                case 3:
                    CountTextBlock.Text = "Цена: 400 рублей";
                    price = 400;
                    break;
                case 4:
                    CountTextBlock.Text = "Цена: 600 рублей";
                    price = 600;
                    break;
                default: CountTextBlock.Text = "Выберите пиццу из списка меню.";
                    price = 0;
                    break;
            }
        }

        private void AddToCheckButtonClick(object sender, RoutedEventArgs e)
        {
            finalPrice += price;
            PriceTextBlock.Text = "Итоговая Стоимость: " + finalPrice;
        }
    }
}
