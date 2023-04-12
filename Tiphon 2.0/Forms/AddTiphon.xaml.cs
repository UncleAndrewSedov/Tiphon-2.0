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
using Tiphon_2._0.Models;

namespace Tiphon_2._0.Forms
{
    /// <summary>
    /// Логика взаимодействия для AddTiphon.xaml
    /// </summary>
    public partial class AddTiphon : Window
    {
        public Product Product { get; set; }
        public AddTiphon()
        {
            InitializeComponent();
            Product = new Product();
            DataContext = Product;
            Product.Id = Guid.NewGuid();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Metods.Metod.AddProduct (Product.Id, Product.Name, Product.Price, Product.Description);
            MainWindow mainWindow = new MainWindow();
            Close();         
            mainWindow.ShowDialog();

        }

        private void btn_madeQr_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
