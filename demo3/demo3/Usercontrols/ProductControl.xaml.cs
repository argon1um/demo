using demo3.Models;
using demo3.Utility;
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

namespace demo3.Usercontrols
{
    /// <summary>
    /// Логика взаимодействия для ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        List<Product> products = App.Context.Products.ToList();
        public Product CurrenProduct;

        public ProductControl(Product product)
        {
            InitializeComponent();
            CurrenProduct = product;
            DataContext = product;
            BrushConverter bc = new BrushConverter();
            decimal oldprice = (Math.Round(((decimal)(product.Productprice + product.Productprice / 100 * product.Productdiscount)), 2));
            WoDiscPrice.Text = oldprice.ToString();
            if (product.Productdiscount >= 15)
            {
                ProductGrid.Background = ((Brush)bc.ConvertFrom("#7fff00"));
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                ImageProduct.Source = ImagePath.GetBitmapImage(CurrenProduct.Productimage);
            }
            catch 
            {
                ImageProduct.Source = ImagePath.GetBitmapImage();
            }

        }
    }
}
