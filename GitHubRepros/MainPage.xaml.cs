namespace GitHubRepros
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnStatusbarBehaviorRepro1Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("statusbarbehavior_repro1");
        }

        private async void OnStatusbarBehaviorRepro2Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("statusbarbehavior_repro2");
        }

        private async void OnOrientationReproClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("orientation_repro");
        }

        private async void OnGridBugReproReproClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("gridbug_repro");
        }

        private async void OnIosMarginBugRepro(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("iosmarginbug_repro");
        }

        private async void OnStatusbarBehaviorRepro3Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("statusbarbehavior_repro3");
        }

        private async void OnCollectionViewScrollBugRepro(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("collectionviewscrollbug_repro");
        }

        private async void OnEntryFocusBugReproClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("entryfocusbugrepro");
        }
    }
}
