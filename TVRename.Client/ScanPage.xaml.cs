using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TVRename.Client
{
    /// <summary>
    /// The scanning page
    /// </summary>
    public sealed partial class ScanPage : Page
    {
        public ScanPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            MainPage.Current.NavigationView.Header = "Scan";
        }

    }
}
