using Microsoft.Web.WebView2.Core;
using System;
using System.Threading.Tasks;

namespace WebBrowserThinClient.Services
{
    public class WebViewService
    {
        private readonly CoreWebView2 _webView;

        public WebViewService(CoreWebView2 webView)
        {
            _webView = webView;
        }

        public async Task NavigateToUrlAsync(string url)
        {
            if (_webView != null)
            {
                await _webView.EnsureCoreWebView2Async();
                _webView.Source = new Uri(url);
            }
            else
            {
                throw new InvalidOperationException("WebView is not initialized.");
            }
        }
    }
}