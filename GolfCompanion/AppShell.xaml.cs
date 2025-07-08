using GolfCompanion.Views;

namespace GolfCompanion
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
        }
    }
}
