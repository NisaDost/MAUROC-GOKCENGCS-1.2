using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GCS_UI.Core;
using GCS_UI.Services;

namespace GCS_UI.ViewModel
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        private readonly NavigationService _navigation;
        private string _welcomeMessage;

        public string WelcomeMessage
        {
            get => _welcomeMessage;
            set { _welcomeMessage = value; OnPropertyChanged(); }
        }

        public HomePageViewModel(NavigationService navigation)
        {
            _navigation = navigation;
            WelcomeMessage = "Welcome to the Ground Control Station!";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
