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
            await MapWebView.EnsureCoreWebView2Async(null);
            string tempPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory).Split("bin")[0];
            string htmlPath = Path.Combine(tempPath, "Resources", "MapPage.html");
            MapWebView.CoreWebView2.Navigate(htmlPath);
        }

        // Call JavaScript function to draw the route
        private void DrawRoute()
        {
            if (MapWebView?.CoreWebView2 != null)
            {
                MapWebView.CoreWebView2.ExecuteScriptAsync("drawRoute();");
            }
        }

        // Call JavaScript function to clear the route
        private void ClearRoute()
        {
            if (MapWebView?.CoreWebView2 != null)
            {
                MapWebView.CoreWebView2.ExecuteScriptAsync("clearRoute();");
            }
        }

        // Button Click Handlers
        private void DrawRouteButton_Click(object sender, RoutedEventArgs e)
        {
            DrawRoute();
        }

        private void ClearRouteButton_Click(object sender, RoutedEventArgs e)
        {
            ClearRoute();
        }
    }
}
