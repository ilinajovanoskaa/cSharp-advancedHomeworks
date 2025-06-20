namespace TimeTracking.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateUsername(string username)
        {
            return username.Length >= 5;
        }

        public static bool ValidatePassword(string password)
        {
            return password.Length >= 6 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsDigit);
        }

        public static bool ValidateName(string name)
        {
            return name.Length >= 2 && name.All(char.IsLetter);
        }

        public static bool ValidateAge(int age)
        {
            return age >= 18 && age <= 120;
        }

        public static int ValidateNumberInput(string inputNumber, int range)
        {
            bool isNumber = int.TryParse(inputNumber, out int num);

            if (!isNumber)
            {
                
                ExtendedConsole.PrintError("Invalid input. Please enter a number.");
                return -1;
            }

            if (num <= 0 || num > range)
            {
                ExtendedConsole.PrintError($"Please enter a number between 1 and {range}.");
                return -1;
            }

            return num;
        }
        public static bool ValidateStringInput(string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

    }
}
