using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TVRename.Client
{
    /// <summary>
    /// The welcome page
    /// </summary>
    public sealed partial class StartPage : Page
    {
        public StartPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            MainPage.Current.NavigationView.Header = "Welcome to TVRename";
        }

    }
}
