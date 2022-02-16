using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf_task_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Яблоки",
                ProdPrice = 120,
                ProdImage = @"C:\Users\1\source\repos\Wpf_task_14\Wpf_task_14\Data\яблоки.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Грейпфруты",
                ProdPrice = 150,
                ProdImage = @"C:\Users\1\source\repos\Wpf_task_14\Wpf_task_14\Data\грейпфруты.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Пылесос",
                ProdPrice = 7000,
                ProdImage = @"C:\Users\1\source\repos\Wpf_task_14\Wpf_task_14\Data\пылесос.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Стиральная машина",
                ProdPrice = 35000,
                ProdImage = @"C:\Users\1\source\repos\Wpf_task_14\Wpf_task_14\Data\стиральная машина.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}