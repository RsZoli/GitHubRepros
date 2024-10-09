using System.Collections.ObjectModel;

namespace GitHubRepros
{
    public partial class IosMarginBugRepro : ContentPage
    {
        public ObservableCollection<string> TestDatas { get; set; }

        public IosMarginBugRepro()
        {
            TestDatas = [];

            NavigatedTo += IosMarginBugRepro_NavigatedTo;

            InitializeComponent();

            BindingContext = this;
        }

        private async void IosMarginBugRepro_NavigatedTo(object sender, NavigatedToEventArgs e)
        {
            await Task.Run(async () =>
            {
                for (int i = 0; i < 5; i++)
                {
                    await MainThread.InvokeOnMainThreadAsync(() =>
                    {
                        TestDatas.Add(i.ToString());
                    });
                }
            });
        }
    }
}
