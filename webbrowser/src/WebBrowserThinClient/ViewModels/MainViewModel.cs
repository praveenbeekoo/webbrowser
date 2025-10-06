using System.ComponentModel;
using System.Runtime.CompilerServices;
using WebBrowserThinClient.Services;

namespace WebBrowserThinClient.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _url;

        public string Url
        {
            get => _url;
            set
            {
                if (_url != value)
                {
                    _url = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainViewModel()
        {
            // Load URL from app.properties, fallback to example
            Url = ConfigService.Get("remote.url", "https://www.example.com");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}