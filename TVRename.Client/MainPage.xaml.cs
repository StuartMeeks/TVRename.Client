using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TVRename.Client
{
    /// <summary>
    /// The main page
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public static MainPage Current;

        public NavigationView NavigationView => MainNavigationView;

        public MainPage()
        {
            this.InitializeComponent();

            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            var titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;

            Current = this;
        }

        private void MainNavigationView_OnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                if (!(args.SelectedItem is NavigationViewItem item))
                {
                    return;
                }

                switch (item.Tag)
                {
                    case "Shows":
                        ContentFrame.Navigate(typeof(ShowsPage));
                        break;

                    case "Scan":
                        ContentFrame.Navigate(typeof(ScanPage));
                        break;

                    case "Guide":
                        ContentFrame.Navigate(typeof(TVRename.Client.GuidePage));
                        break;

                    case "Start":
                        ContentFrame.Navigate(typeof(StartPage));
                        break;

                    default:
                        return;
                }
            }
        }

        private void MainNavigationView_OnItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                switch (args.InvokedItem)
                {
                    case "Shows":
                        ContentFrame.Navigate(typeof(ShowsPage));
                        break;

                    case "Scan":
                        ContentFrame.Navigate(typeof(ScanPage));
                        break;

                    case "Guide":
                        ContentFrame.Navigate(typeof(TVRename.Client.GuidePage));
                        break;

                    case "Start":
                        ContentFrame.Navigate(typeof(StartPage));
                        break;

                    default:
                        return;
                }

            }
        }

        private void MainNavigationView_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (NavigationViewItemBase menuItem in MainNavigationView.MenuItems)
            {
                if (menuItem is NavigationViewItem && menuItem.Tag.ToString() == "Start")
                {
                    MainNavigationView.SelectedItem = menuItem;
                    break;
                }
            }
        }
    }
}
