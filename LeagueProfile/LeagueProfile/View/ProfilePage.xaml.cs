﻿using LeagueProfile.Control;
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
    /// Interakční logika pro ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        Frame mainframe;
        public ProfilePage(Frame Mainframe)
        {
            Controller controller = new Controller();
            mainframe = Mainframe;
            InitializeComponent();
            this.DataContext = controller.GetContext();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            mainframe.NavigationService.Navigate(new SearchMenu(mainframe));
        }
    }
}
