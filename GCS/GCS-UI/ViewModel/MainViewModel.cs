using GCS_UI.Core;
using GCS_UI.Services;

namespace GCS_UI.ViewModel
{
    public class MainViewModel
    {
        public NavigationService Navigation { get; }

        public MainViewModel(NavigationService navigation)
        {
            Navigation = navigation;
        }
    }
}



