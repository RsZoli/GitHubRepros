using CommunityToolkit.Maui.Views;

namespace GitHubRepros;

public partial class EntryFocusBugRepro : ContentPage
{
	public EntryFocusBugRepro()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await this.ShowPopupAsync(new Popup());

    }
}
