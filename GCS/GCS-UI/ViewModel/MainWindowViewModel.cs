using GCS_UI.Core;
using GCS_UI.Services;

namespace GCS_UI.ViewModel
{
    public class MainWindowViewModel
    {
        public NavigationService Navigation { get; }

        public MainWindowViewModel(NavigationService navigation)
        {
            Navigation = navigation;
        }
    }
}



