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

namespace T1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBuy_click(object sender, RoutedEventArgs e)
        {
            if ((bool)cbMilk.IsChecked)
            {
                txbShopList.Text = cbMilk.Content.ToString();
                if ((bool)cbButter.IsChecked)
                    txbShopList.Text += ", " + cbButter.Content.ToString();
                if ((bool)cbBeer.IsChecked)
                    txbShopList.Text += ", " + cbBeer.Content.ToString();
                if ((bool)cbChicken.IsChecked)
                    txbShopList.Text += ", " + cbChicken.Content.ToString();
                if ((bool)cbLemonade.IsChecked)
                    txbShopList.Text += ", " + cbLemonade.Content.ToString();
            }
            else if ((bool)cbButter.IsChecked)
            {
                txbShopList.Text = cbButter.Content.ToString();
                if ((bool)cbBeer.IsChecked)
                    txbShopList.Text += ", " + cbBeer.Content.ToString();
                if ((bool)cbChicken.IsChecked)
                    txbShopList.Text += ", " + cbChicken.Content.ToString();
                if ((bool)cbLemonade.IsChecked)
                    txbShopList.Text += ", " + cbLemonade.Content.ToString();
            }
            else if ((bool)cbBeer.IsChecked)
            {
                txbShopList.Text = cbBeer.Content.ToString();
                if ((bool)cbChicken.IsChecked)
                    txbShopList.Text += ", " + cbChicken.Content.ToString();
                if ((bool)cbLemonade.IsChecked)
                    txbShopList.Text += ", " + cbLemonade.Content.ToString();
            }
            else if ((bool)cbChicken.IsChecked)
            {
                txbShopList.Text = cbChicken.Content.ToString();
                if ((bool)cbLemonade.IsChecked)
                    txbShopList.Text += ", " + cbLemonade.Content.ToString();
            }
            else if ((bool)cbLemonade.IsChecked)
                txbShopList.Text = cbLemonade.Content.ToString();
            else
                txbShopList.Text = "";

        }
    }
}
