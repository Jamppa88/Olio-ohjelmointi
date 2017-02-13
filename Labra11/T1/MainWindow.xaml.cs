using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
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
using JAMK.ICT;

namespace T1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HockeyLeague tiimit;
        ObservableCollection<HockeyTeam> joukkueet;
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            IniMyStuff();
        }
        private void IniMyStuff()
        {
            // tänne kootusti omien kontrollien alustukset
            List<string> muuvit = new List<string>();
            muuvit.Add("Halloween");
            muuvit.Add("Zombeavers");
            muuvit.Add("Star Wars Episode IV");
            muuvit.Add("Pirun pikku kätyri");
            combCode.ItemsSource = muuvit;
            tiimit = new HockeyLeague();
            joukkueet = tiimit.GetTeams();
            combTeams.ItemsSource = tiimit.GetTeams();
           
        }

        private void btnBind_click(object sender, RoutedEventArgs e)
        {
            // määritellään StackPanelin DataContext
            // Demo 1: Datakonteksti on olio
            // HockeyTeam tiimi = new HockeyTeam("KeuPa", "Keuruu");
            // spRight.DataContext = tiimi;
            // demo 2: kytketään olio kokoelma 1. olioon
            spRight.DataContext = joukkueet[counter];
        }

        private void btnBack_click(object sender, RoutedEventArgs e)
        {
            if (counter == 0)
                counter = 0;
            else
            {
                counter--;
                spRight.DataContext = joukkueet[counter];
            }
        }

        private void btnForward_click(object sender, RoutedEventArgs e)
        {
            if (counter == joukkueet.Count - 1)
                counter = joukkueet.Count - 1;
            else
            {
                counter++;
                spRight.DataContext = joukkueet[counter];
            }
                
        }
    }
}
