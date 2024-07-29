using CommunityToolkit.Maui.Core;

namespace GitHubRepros
{
    public partial class MainPage : ContentPage
    {
        private StatusBarStyle _statusBarStyleProperty;
        public StatusBarStyle StatusBarStyleProperty
        {
            get => _statusBarStyleProperty;
            set
            {
                if(_statusBarStyleProperty != value)
                {
                    _statusBarStyleProperty = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainPage()
        {
            _statusBarStyleProperty = StatusBarStyle.LightContent;

            InitializeComponent();

            BindingContext = this;
        }

        private async void OnOrientationReproClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("orientation_repro");
        }

        private async void OnStatusbarBehaviorRepro1Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("statusbarbehavior_repro1");
        }

        private async void OnStatusbarBehaviorRepro2Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("statusbarbehavior_repro2");
        }

        private async void OnGridBugReproReproClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("gridbug_repro");
        }
    }
}
