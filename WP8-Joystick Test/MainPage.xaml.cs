using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WP8_Joystick_Test.Resources;
using WP8_Joystick;
using System.Diagnostics;

namespace WP8_Joystick_Test
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            joystick1.StartJoystick();

            base.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            joystick1.StopJoystick();

            base.OnNavigatedFrom(e);
        }


        void joystick1_NewCoordinates(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Joystick_NewCoordinates_1(object sender, EventArgs e)
        {
            tbX.Text = ((MyCoordinates)e).Direction.ToString();
            tbY.Text = ((MyCoordinates)e).Speed.ToString();

        }

        private void joystick1_Stop(object sender, EventArgs e)
        {
            tbX.Text = "";
            tbY.Text = "";
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}