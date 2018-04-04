using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TVRename.Client
{
    /// <summary>
    /// The settings page
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            MainPage.Current.NavigationView.Header = "Settings";
        }
    }
}
