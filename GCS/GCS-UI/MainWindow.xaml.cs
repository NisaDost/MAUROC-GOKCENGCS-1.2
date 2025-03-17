using System.Windows;
using GCS_UI.View;

namespace GCS_UI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MainFrame.NavigationService.Navigate(new LoginPage());
            MainFrame.NavigationService.Navigate(new HomePage());
        }
    }
}
