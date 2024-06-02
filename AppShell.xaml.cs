namespace PowerGenerationLocationChecker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Views.SuppliersPage), typeof(Views.SuppliersPage));
            Routing.RegisterRoute(nameof(Views.MapPage), typeof(Views.MapPage));
            Routing.RegisterRoute(nameof(Views.ResultsPage), typeof(Views.ResultsPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}
