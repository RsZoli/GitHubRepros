namespace GitHubRepros;

public partial class OrientationRepro : ContentPage
{
    private DisplayOrientation _displayOrientation;
    public DisplayOrientation DisplayOrientation
    {
        get { return _displayOrientation; }
        set
        {
            if (_displayOrientation != value)
            {
                _displayOrientation = value;
                OnPropertyChanged();
            }
        }
    }

    private StackOrientation _stackLayoutOrientation;
    public StackOrientation StackLayoutOrientation
    {
        get { return _stackLayoutOrientation; }
        set
        {
            if (_stackLayoutOrientation != value)
            {
                _stackLayoutOrientation = value;
                OnPropertyChanged();
            }
        }
    }

    public OrientationRepro()
	{
        _displayOrientation = DeviceDisplay.Current.MainDisplayInfo.Orientation;
        _stackLayoutOrientation = StackOrientation.Vertical;

        DeviceDisplay.Current.MainDisplayInfoChanged -= Current_MainDisplayInfoChanged;
        DeviceDisplay.Current.MainDisplayInfoChanged += Current_MainDisplayInfoChanged;

        InitializeComponent();

        BindingContext = this;
	}

    private void Current_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
    {
        DisplayOrientation = e.DisplayInfo.Orientation;

        if (e.DisplayInfo.Orientation == DisplayOrientation.Landscape)
        {
            StackLayoutOrientation = StackOrientation.Horizontal;
        }
        else
        {
            StackLayoutOrientation = StackOrientation.Vertical;
        }
    }
}
