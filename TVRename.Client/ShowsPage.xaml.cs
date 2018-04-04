using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TVRename.Client
{
    /// <summary>
    /// The shows page
    /// </summary>
    public sealed partial class ShowsPage : Page
    {
        public ShowsPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            MainPage.Current.NavigationView.Header = "Shows";
        }
    }
}
