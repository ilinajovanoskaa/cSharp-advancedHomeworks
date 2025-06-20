using TimeTracking.Domain.Models;
using TimeTracking.Helpers;
using TimeTracking.Services.Abstractions;
using TimeTracking.Services.Abstractions.Interfaces;

namespace TimeTracking.Services.Implementation
{
    public class AuthService : ServiceBase<User>, IAuthService
    {
        public User CurrentUser { get; set; }

        public void LogIn(string username, string password)
        {
            List<User> allUsers = GetAll();
            User userDB = allUsers.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (userDB is null)
            {
                throw new Exception("Login failed! Invalid username or password ! Please try again...");
            }
            CurrentUser = userDB;
        }

        public void Register(string username, string password)
        {
            List<User> usersDB = GetFiltered(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            bool userExist = usersDB.Any();
            if (userExist)
            {
                throw new Exception("User already exists");
            }

            User newUser = new User(username, password);
            Insert(newUser);
           
            

        }

        public void LogOut()
        {
            if (CurrentUser != null)
            {
                Console.WriteLine($"You have successfully logged out !");
                CurrentUser = null;
            }
            else
            {
                Console.WriteLine("No user is currently logged in.");
            }
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (CurrentUser.Password != oldPassword || !ValidationHelper.ValidatePassword(newPassword) || oldPassword == newPassword)
            {
                return false;
            }
            CurrentUser.Password = newPassword;
            bool isUpdated = Update(CurrentUser);
            return isUpdated;
        }

        public bool ChangeFirstName(string oldFName, string newFName)
        {
            if (string.IsNullOrWhiteSpace(oldFName) || string.IsNullOrWhiteSpace(newFName))
            {
                return false;
            }

            if (!CurrentUser.FirstName.Equals(oldFName, StringComparison.OrdinalIgnoreCase) ||
            oldFName.Equals(newFName, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            CurrentUser.FirstName = newFName.Trim();
            bool isUpdated = Update(CurrentUser);
            return isUpdated;
        }
        public bool ChangeLastName(string oldLName, string newLName)
        {
            if (string.IsNullOrWhiteSpace(oldLName) || string.IsNullOrWhiteSpace(newLName))
            {
                return false;
            }
            if (!CurrentUser.FirstName.Equals(oldLName, StringComparison.OrdinalIgnoreCase) ||
            oldLName.Equals(newLName, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            CurrentUser.LastName = newLName.Trim();
            bool isUpdated = Update(CurrentUser);
            return isUpdated;
        }
    }
}
