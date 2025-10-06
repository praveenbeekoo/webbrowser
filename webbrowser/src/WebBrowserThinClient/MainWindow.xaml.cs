using System;
using System.Windows;
using Microsoft.Web.WebView2.Wpf;
using WebBrowserThinClient.ViewModels;

namespace WebBrowserThinClient
{
    public partial class MainWindow : Window
    {
        private WebView2 webView;
        private readonly MainViewModel _vm;

        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            DataContext = _vm;
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            try
            {
                webView = this.webView ?? new WebView2();

                // When the control is present in XAML we can reference it by name
                if (webView == null)
                {
                    webView = new WebView2();
                    Content = webView;
                }

                await webView.EnsureCoreWebView2Async(null);

                var url = _vm.Url ?? "https://www.example.com";
                webView.Source = new Uri(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize WebView2: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}