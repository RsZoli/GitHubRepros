namespace GitHubRepros;

public partial class StatusbarBehaviorRepro1 : ContentPage
{
	public StatusbarBehaviorRepro1()
	{
        SizeChanged += StatusbarBehaviorRepro1_SizeChanged;

		InitializeComponent();
	}

    private void StatusbarBehaviorRepro1_SizeChanged(object? sender, EventArgs e)
    {

    }
}