using System.Collections.ObjectModel;

namespace GitHubRepros
{
    public partial class CollectionViewScrollBugRepro : ContentPage
    {
        private int _scrollToIndex;
        public int ScrollToIndex
        {
            get => _scrollToIndex;
            set
            {
                if (_scrollToIndex != value)
                {
                    _scrollToIndex = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<int> CvItems { get; set; }

        public CollectionViewScrollBugRepro()
        {
            CvItems = [];

            NavigatedTo += CollectionViewScrollBugRepro_NavigatedTo;

            InitializeComponent();

            BindingContext = this;
        }

        private async void CollectionViewScrollBugRepro_NavigatedTo(object sender, NavigatedToEventArgs e)
        {
            await Task.Run(async () =>
            {
                for (int i = 0; i < 50; i++)
                {
                    await MainThread.InvokeOnMainThreadAsync(() =>
                    {
                        CvItems.Add(i);
                    });
                }
            });
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CollectionView_BugReport.ScrollTo(ScrollToIndex, position: ScrollToPosition.Start);
        }
    }
}
