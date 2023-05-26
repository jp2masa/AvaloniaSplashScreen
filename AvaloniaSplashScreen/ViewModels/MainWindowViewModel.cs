using System.Threading.Tasks;

using Avalonia.Threading;

using ReactiveUI;

namespace AvaloniaSplashScreen.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _content = new SplashScreenViewModel();

        public MainWindowViewModel(Task<MainViewModel> mainTask)
        {
            mainTask.ContinueWith(x => Dispatcher.UIThread.InvokeAsync(() => Content = x.Result));
        }

        public ViewModelBase Content
        {
            get => _content;
            private set => this.RaiseAndSetIfChanged(ref _content, value);
        }
    }
}
