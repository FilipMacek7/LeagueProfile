using LeagueProfile.Control;
using LeagueProfile.Utils;
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

namespace LeagueProfile.View
{
    /// <summary>
    /// Interakční logika pro Menu.xaml
    /// </summary>
    public partial class SearchMenu : Page
    {
        Controller controller = new Controller();
        Frame mainframe;
        public SearchMenu(Frame Mainframe)
        {
            InitializeComponent();
            mainframe = Mainframe;
        }      
        


        private void Search(object sender, RoutedEventArgs e)
        {
            var selectedRegion = ((ComboBoxItem)regioncombo.SelectedItem).Tag.ToString();

            if (string.IsNullOrEmpty(selectedRegion))
                return;
            if (string.IsNullOrEmpty(summonertext.Text))
                return;
            Constant.Region = selectedRegion;
            if (controller.GetSummoner(summonertext.Text))
            {
                mainframe.NavigationService.Navigate(new ProfilePage(mainframe));
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}
