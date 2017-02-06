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

namespace T2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double euroToDol = 1.0741;
        double dolToEuro = 0.9359;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void euro_click(object sender, RoutedEventArgs e)
        {
            errorTextBlock.Text = "";
            try
            {
                double euroGet = double.Parse(euroTextBox.Text) * euroToDol;
                dollarTextBox.Text = euroGet.ToString("0.00");
            } catch (Exception ex)
            {
                errorTextBlock.Text = String.Format("Virhe! ({0})", ex.Message);
            }
            
        }

        private void dollar_click(object sender, RoutedEventArgs e)
        {
            errorTextBlock.Text = "";
            try
            {
                double dollarGet = double.Parse(dollarTextBox.Text) * dolToEuro;
                euroTextBox.Text = dollarGet.ToString("0.00");
            }
            catch (Exception ex)
            {
                errorTextBlock.Text = String.Format("Virhe! ({0})", ex.Message);
            }
            
        }
    }
}
