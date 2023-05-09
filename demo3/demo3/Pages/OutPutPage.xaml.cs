using demo3.Models;
using demo3.Usercontrols;
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

namespace demo3.Pages
{
    /// <summary>
    /// Логика взаимодействия для OutPutPage.xaml
    /// </summary>
    public partial class OutPutPage : Page
    {
        List<Product> products = App.Context.Products.ToList();
        string[] discounts = { "Все диапозоны", "0-9.99%", "10-14.99%", "15% и более" };
        string[] updown = { "Сначала дешевле", "Сначала дороже" };
        int maxcount = 0;
        public OutPutPage()
        {
            InitializeComponent();
            UpDownCb.ItemsSource = updown;
            DiscountCb.ItemsSource = discounts;
            maxcount = products.Count;

        }

        private void UpDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UpDownCb.SelectedIndex == 0)
            {
                OrderOnUp();
            }
            else
            {
                OrderOnDown();
            }
        }

        private void Discount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UpDownCb.SelectedIndex == 0)
            {
                OrderOnUp();
            }
            else
            {
                OrderOnDown();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            OrderOnUp();
            CountTextbox.Text = $"{products.Count()}/{products.Count()}";
        }

        private void OrderOnUp()
        {
            if (DiscountCb.SelectedIndex == 0)
            {
                ProductPanel.Children.Clear();
                InFilteredList(products.OrderBy(x => x.Productprice).ToList());
                return;
            }
            else if (DiscountCb.SelectedIndex == 1)
            {
                ProductPanel.Children.Clear();
                InFilteredList(products.Where(x =>x.Productdiscount<10).OrderBy(x=>x.Productprice).ToList());
                return;
            }
            else if (DiscountCb.SelectedIndex == 2)
            {
                ProductPanel.Children.Clear();
                InFilteredList(products.Where(x => x.Productdiscount >= 10 && x.Productprice < 15).OrderBy(x => x.Productprice).ToList());
                return;
            }
            else
            {
                ProductPanel.Children.Clear();
                InFilteredList(products.Where(x => x.Productdiscount >= 15).OrderBy(x => x.Productprice).ToList());
                return;
            }
        }

        private void OrderOnDown()
        {
            if (DiscountCb.SelectedIndex == 0)
            {
                ProductPanel.Children.Clear();
                InFilteredList(products.OrderByDescending(x => x.Productprice).ToList());
                return;
            }
            else if (DiscountCb.SelectedIndex == 1)
            {
                ProductPanel.Children.Clear();
                InFilteredList(products.Where(x => x.Productdiscount < 10).OrderByDescending(x => x.Productprice).ToList());
                return;
            }
            else if (DiscountCb.SelectedIndex == 2)
            {
                ProductPanel.Children.Clear();
                InFilteredList(products.Where(x => x.Productdiscount >= 10 && x.Productprice < 15).OrderByDescending(x => x.Productprice).ToList());
                return;
            }
            else
            {
                ProductPanel.Children.Clear();
                InFilteredList(products.Where(x => x.Productdiscount >= 15).OrderByDescending(x => x.Productprice).ToList());
                return;
            }
        }

        private void InFilteredList(IEnumerable<Product> products)
        {
            foreach (Product product in products)
            {
                ProductPanel.Children.Add(new ProductControl(product));
            }

            CountTextbox.Text = $"{products.Count()}/{maxcount}";
            
        }

    }
}
