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

namespace T3
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

        private void laske_click(object sender, RoutedEventArgs e)
        {
            try
            {
                double h = double.Parse(H_textBox.Text);
                double l = double.Parse(L_textBox.Text);
                double w = double.Parse(W_textBox.Text);

                areaWindowTextBox.Text = AreaWindow(l, h);
                areaGlassTextBox.Text = AreaGlass(l, h, w);
                circumTextBox.Text = Circumference(l, h);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string AreaWindow(double l, double h)
        {
           
            return (l * h/100).ToString("0") + " cm^2";
        }
        public string AreaGlass(double l, double h, double w)
        {
            
            return ((l-w)*(h-w)/100).ToString("0") + " cm^2";
        }
        public string Circumference(double l, double h)
        {
            return (2*(l+h)/10).ToString("0") + " cm";
        }
    }
}
