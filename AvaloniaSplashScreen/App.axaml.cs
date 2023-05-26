using System.Threading.Tasks;

using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using AvaloniaSplashScreen.ViewModels;
using AvaloniaSplashScreen.Views;

namespace AvaloniaSplashScreen
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(LoadAsync()),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }

        private async Task<MainViewModel> LoadAsync()
        {
            await Task.Delay(3000);
            return new MainViewModel();
        }
    }
}
