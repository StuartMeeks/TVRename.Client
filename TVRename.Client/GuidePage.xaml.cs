using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TVRename.Client
{
    /// <summary>
    /// The guide page
    /// </summary>
    public sealed partial class GuidePage : Page
    {
        public GuidePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            MainPage.Current.NavigationView.Header = "Guide";
        }

    }
}
