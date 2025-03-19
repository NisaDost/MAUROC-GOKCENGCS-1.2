using GCS_UI.Core;
using GCS_UI.Services;
using GCS_UI.View;

namespace GCS_UI.ViewModel
{
    public class LoginPageViewModel
    {
        private readonly NavigationService _navigation;
        private readonly AuthService _authService = new AuthService();

        public string Username { get; set; }
        public string Password { get; set; }
        public RelayCommand LoginCommand { get; }

        public LoginPageViewModel(NavigationService navigation)
        {
            _navigation = navigation;
            LoginCommand = new RelayCommand(ExecuteLogin);
        }

        private void ExecuteLogin(object obj)
        {
            var user = _authService.Authenticate(Username, Password);
            if (user != null)
            {
                _navigation.Navigate(new HomePage());
            }
        }
    }
}
