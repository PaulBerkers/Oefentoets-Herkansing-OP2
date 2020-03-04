using Oefentoets_Herkansing_OP2.Classes;
using Oefentoets_Herkansing_OP2.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Oefentoets_Herkansing_OP2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<MenuItems> _menuItems;
        public MainPage()
        {
            this.InitializeComponent();

            _menuItems = new ObservableCollection<MenuItems>()
            {
                new MenuItems(
                    typeof(VerenigingToevoegen),
                    "Vereniging toevoegen",Symbol.Add),
                new MenuItems(
                    typeof(VerenigingTonen),
                    "Vereniging tonen",Symbol.People)

            };
            fRootFrame.Navigate(_menuItems[0].Page);
        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            MenuItems mi = (MenuItems)sender.SelectedItem;
            fRootFrame.Navigate(mi.Page);
        }

        private void NavigationView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (fRootFrame.CanGoBack)
            {
                fRootFrame.GoBack();
            }

        }
    }
}
