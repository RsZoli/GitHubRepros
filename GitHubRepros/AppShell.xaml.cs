namespace GitHubRepros
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute("orientation_repro", typeof(OrientationRepro));
            Routing.RegisterRoute("statusbarbehavior_repro1", typeof(StatusbarBehaviorRepro1));
            Routing.RegisterRoute("statusbarbehavior_repro2", typeof(StatusbarBehaviorRepro2));

            InitializeComponent();
        }
    }
}
