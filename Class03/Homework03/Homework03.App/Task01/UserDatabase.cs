namespace Homework03.App.Task01
{
    public static class UserDatabase
    {
        public static List<User> Users { get; set; } = new List<User>();

        

        public static List<User> Search(string type, string value)
        {
            List<User> result = new List<User>();

            Users = new List<User>()
            {
                new User(1, "Bob", 25),
                new User(2, "Jill", 33),
                new User(3, "Alice", 21),
                new User(4, "Johnny", 18),
            };

            foreach (User user in Users)
            {
                if (type == "id" && user.Id.ToString() == value)
                {
                    result.Add(user);
                }
                else if (type == "name" && user.Name == value)
                {
                    result.Add(user);
                }
                else if (type == "age" && user.Age.ToString() == value)
                {
                    result.Add(user);
                }
            }

            return result;
        }


    }
}
