using CSLab1.Views;

namespace CSLab1 {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TestPage), typeof(TestPage));
        }
    }
}
