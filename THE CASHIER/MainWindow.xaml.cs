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

namespace THE_CASHIER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new calculator();
            listBox.ItemsSource = calculator.getlisitem();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = itemNameBox.Text;
            int quantity = int.Parse(quantityBox.Text);
            string type = typeBox.Text;
            double price = double.Parse(priceBox.Text);

            Item item = new Item(new Random().Next(),title,quantity,type,price);
            calculator.additem(item);
            double total = calculator.gettotal();

            totalLabel.Content = string.Format("Rp. {0}", total);
            listBox.Items.Refresh();

        }
    }
}
