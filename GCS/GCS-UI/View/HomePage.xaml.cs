using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace GCS_UI.View   
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            // Ensure WebView2 is initialized
            await MapWebView.EnsureCoreWebView2Async(null);

            // Example: Navigate to a local HTML file (e.g., MapPage.html) in your project
            string tempPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory).Split("bin")[0];
            string htmlPath = Path.Combine(tempPath, "Resources", "MapPage.html");
            MapWebView.CoreWebView2.Navigate(htmlPath);
        }
    }
}
