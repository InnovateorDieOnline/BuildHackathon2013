using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using LiveCycle.Resources;
using LiveCycle.Data;
using System.ComponentModel;

namespace LiveCycle
{
    public partial class MainPage : PhoneApplicationPage
    {
        public DefaultViewModel DefaultViewModel
        {
            get { return (DefaultViewModel)GetValue(DefaultViewModelProperty); }
            set { SetValue(DefaultViewModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DefaultViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DefaultViewModelProperty =
            DependencyProperty.Register("DefaultViewModel", typeof(DefaultViewModel), typeof(MainPage), new PropertyMetadata(0));

        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
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