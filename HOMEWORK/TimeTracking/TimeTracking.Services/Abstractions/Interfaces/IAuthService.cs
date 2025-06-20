using TimeTracking.Domain.Models;

namespace TimeTracking.Services.Abstractions.Interfaces
{
    public interface IAuthService : IServiceBase<User>
    {
        User CurrentUser { get; set; }
        void Register(string username, string password);
        void LogIn(string username, string password);
        void LogOut();
        bool ChangePassword(string oldPassword, string newPassword);
        bool ChangeFirstName(string oldFName, string newFName);
        bool ChangeLastName(string oldLName, string newLName);
    }
}
