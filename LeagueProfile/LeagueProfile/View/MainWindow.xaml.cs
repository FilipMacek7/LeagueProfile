using LeagueProfile.Control;
using LeagueProfile.Utils;
using LeagueProfile.View;
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

namespace LeagueProfile
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainController controller = new MainController();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            var selectedRegion = ((ComboBoxItem)regioncombo.SelectedItem).Tag.ToString();

            if (string.IsNullOrEmpty(selectedRegion))
                return;
            if (string.IsNullOrEmpty(summonertext.Text))
                return;
            Constant.Region = regioncombo.Text;
            if (controller.GetSummoner(summonertext.Text))
            {
                frame.NavigationService.Navigate(new ProfilePage());
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
