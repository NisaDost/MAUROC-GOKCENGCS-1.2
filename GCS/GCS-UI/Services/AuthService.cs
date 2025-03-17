using GCS_UI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_UI.Services
{
    public class AuthService
    {
        private readonly ObservableCollection<User> _users = new ObservableCollection<User>
        {
            new User { Username = "admin", Password = "1234", Role = new Role { Name = "Admin", ClearanceLevel = 10 } },
            new User { Username = "operator", Password = "5678", Role = new Role { Name = "Operator", ClearanceLevel = 5 } }
        };

        public User Authenticate(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
