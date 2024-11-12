using CommunityToolkit.Maui.Core.Platform;

namespace GitHubRepros
{
    public partial class Popup : CommunityToolkit.Maui.Views.Popup
    {
        public Popup()
        {
            Opened += Popup_Opened;

            InitializeComponent();
        }

        private async void Popup_Opened(object sender, CommunityToolkit.Maui.Core.PopupOpenedEventArgs e)
        {
            await Entry_Popup.ShowKeyboardAsync(CancellationToken.None);
        }
    }
}
