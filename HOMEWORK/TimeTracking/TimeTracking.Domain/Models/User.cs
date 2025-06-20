using TimeTracking.Domain.Enums;

namespace TimeTracking.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
        public TimeSpan Duration { get; set; }
        public List<Activity> Activities { get; set; } = new();

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User()
        {

        }
        


}


}
