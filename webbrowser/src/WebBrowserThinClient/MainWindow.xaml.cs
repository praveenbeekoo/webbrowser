using System;
using System.Windows;
using Microsoft.Web.WebView2.Wpf;
using WebBrowserThinClient.ViewModels;

namespace WebBrowserThinClient
{
    public partial class MainWindow : Window
    {
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
                // The XAML defines a named WebView2 control `webView` that we can use directly.
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