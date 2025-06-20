using System.Diagnostics;
using TimeTracking.Domain.Enums;
using TimeTracking.Domain.Models;
using TimeTracking.Helpers;
using TimeTracking.Services.Abstractions.Interfaces;
using TimeTracking.Services.Enums;
using TimeTracking.Services.Implementation;

namespace TimeTracking.Services.Implementation
{
    public class UIServices
    {
        private readonly AuthService _authService;
        public MainMenuChoice ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Main Menu ===");
            var choices = Enum.GetValues(typeof(MainMenuChoice)).Cast<MainMenuChoice>().ToList();
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {choices[i]}");
            }

            int choice = ValidationHelper.ValidateNumberInput(Console.ReadLine(), choices.Count);
            return choices[choice - 1];
        }
        private ActivityType ChooseActivity()
        {
            Console.Clear();
            Console.WriteLine("Select an activity to track:");

            var activities = Enum.GetValues(typeof(ActivityType)).Cast<ActivityType>().ToList();
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {activities[i]}");
            }

            int choice = ValidationHelper.ValidateNumberInput(Console.ReadLine(), activities.Count);
            return activities[choice - 1];
        }

        private string GetExtraInfo(ActivityType activity)
        {
            switch (activity)
            {
                case ActivityType.Reading:
                    Console.Write("Enter number of pages read: ");
                    string pages = Console.ReadLine();
                    Console.Write("Enter type (Belles Lettres, Fiction, Professional Literature): ");
                    string readingType = Console.ReadLine();
                    return $"Pages: {pages}, Type: {readingType}";

                case ActivityType.Exercising:
                    Console.Write("Enter type (General, Running, Sport): ");
                    return Console.ReadLine();

                case ActivityType.Working:
                    Console.Write("Enter location (At the office or From home): ");
                    return Console.ReadLine();

                case ActivityType.Hobby:
                    Console.Write("Enter name of hobby: ");
                    return Console.ReadLine();

                default:
                    return string.Empty;
            }
        }
        public void TrackActivity()
        {
            Console.Clear();
            Console.WriteLine("Select an activity to track:");
            List<ActivityType> activities = Enum.GetValues(typeof(ActivityType)).Cast<ActivityType>().ToList(); // ova go procitav od https://learn.microsoft.com/en-us/dotnet/api/system.enum.getvalues?view=net-9.0
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {activities[i]}");
            }

            int choice = ValidationHelper.ValidateNumberInput(Console.ReadLine(), activities.Count);
            var selectedActivity = activities[choice - 1];

            Console.WriteLine($"Starting {selectedActivity} tracking. Press Enter to stop.");
            Console.ReadLine();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.ReadLine(); 
            stopwatch.Stop();

            var duration = stopwatch.Elapsed;

            
            var extraInfo = GetExtraInfo(selectedActivity);


            Console.WriteLine($"You spent {duration.TotalMinutes:F2} minutes on {selectedActivity}.");
            Console.WriteLine("Press Enter to return to the main menu.");
            Console.ReadLine();
        }

        public void ShowStatistics(User user)
        {
            bool showStats = true;
            while (showStats)
            {
                Console.Clear();
                Console.WriteLine("===== USER STATISTICS MENU =====");
                Console.WriteLine("1. Reading");
                Console.WriteLine("2. Exercising");
                Console.WriteLine("3. Working");
                Console.WriteLine("4. Hobbies");
                Console.WriteLine("5. Global");
                Console.WriteLine("0. Back to Main Menu");

                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ShowReadingStats(user);
                        break;
                    case "2":
                        ShowExerciseStats(user);
                        break;
                    case "3":
                        ShowWorkingStats(user);
                        break;
                    case "4":
                        ShowHobbiesStats(user);
                        break;
                    case "5":
                        ShowGlobalStats(user);
                        break;
                    case "0":
                        showStats = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                if (showStats)
                {
                    Console.WriteLine("\nPress any key to return to the Statistics Menu...");
                    Console.ReadLine();
                }
            }
        }

        private void ShowReadingStats(User user)
        {
            var readings = user.Activities.Where(a => a.Type == ActivityType.Reading).ToList();
            if (readings.Count == 0)
            {
                Console.WriteLine("No reading records found.");
                return;
            }

            double totalHours = readings.Sum(r => r.Duration.TotalMinutes) / 60.0;
            double avgMinutes = readings.Average(r => r.Duration.TotalMinutes);
            var favType = readings
                .Where(r => !string.IsNullOrWhiteSpace(r.ExtraInfo))
                .GroupBy(r => r.ExtraInfo.Trim())
                .OrderByDescending(r => r.Count())
                .FirstOrDefault();

            Console.WriteLine("----- Reading Stats -----");
            Console.WriteLine($"Total Time: {totalHours:F2} hours");
            Console.WriteLine($"Average Duration: {avgMinutes:F1} minutes");
            Console.WriteLine($"Favorite Type: {favType}");
        }


        private void ShowExerciseStats(User user)
        {
            var exercises = user.Activities.Where(a => a.Type == ActivityType.Exercising).ToList();
            if (exercises.Count == 0)
            {
                Console.WriteLine("No exercise records found.");
                return;
            }

            double totalHours = exercises.Sum(e => e.Duration.TotalMinutes) / 60.0;
            double avgMinutes = exercises.Average(e => e.Duration.TotalMinutes);
            var favType = exercises
            .Where(e => !string.IsNullOrWhiteSpace(e.ExtraInfo))
            .GroupBy(e => e.ExtraInfo.Trim())
            .OrderByDescending(g => g.Count())
            .FirstOrDefault();

            Console.WriteLine("----- Exercise Stats -----");
            Console.WriteLine($"Total Time: {totalHours:F2} hours");
            Console.WriteLine($"Average Duration: {avgMinutes:F1} minutes");
            Console.WriteLine($"Favorite Type: {favType}");
        }


        private void ShowWorkingStats(User user)
        {
            var works = user.Activities
                .Where(a => a.Type == ActivityType.Working)
                .ToList();
            if (works.Count == 0)
            {
                Console.WriteLine("No work records found.");
                return;
            }

            double totalMinutes = works.Sum(w => w.Duration.TotalMinutes);
            double totalHours = totalMinutes / 60.0;
            double avgMinutes = works.Average(w => w.Duration.TotalMinutes);

            double homeHours = works
            .Where(w => w.ExtraInfo.Trim().ToLower() == "home")
            .Sum(w => w.Duration.TotalMinutes) / 60.0;

            double officeHours = works
                .Where(w => w.ExtraInfo.Trim().ToLower() == "office")
                .Sum(w => w.Duration.TotalMinutes) / 60.0; ;

            Console.WriteLine("----- Work Stats -----");
            Console.WriteLine($"Total Time: {totalHours:F2} hours");
            Console.WriteLine($"Average Duration: {avgMinutes:F1} minutes");
            Console.WriteLine($"Home Work Time: {homeHours:F2} hours");
            Console.WriteLine($"Office Work Time: {officeHours:F2} hours");
        }


        private void ShowHobbiesStats(User user)
        {
           var hobbies = user.Activities
                .Where(a => a.Type == ActivityType.Hobby)
                .ToList();           
            

            if (hobbies.Count == 0)
            {
                Console.WriteLine("No hobby records found.");
                return;
            }

            double totalMinutes = hobbies.Sum(h => h.Duration.TotalMinutes);
            double totalHours = totalMinutes / 60.0;
            var uniqueNames = hobbies
            .Select(h => h.ExtraInfo)
            .Where(info => !string.IsNullOrWhiteSpace(info))
            .Distinct();

            Console.WriteLine("----- Hobby Stats -----");
            Console.WriteLine($"Total Time: {totalHours:F2} hours");
            Console.WriteLine("Unique Hobbies:");
            foreach (var name in uniqueNames)
                Console.WriteLine($"- {name}");
        }


        private void ShowGlobalStats(User user)
        {
            if (user.Activities.Count == 0)
            {
                Console.WriteLine("No activity records found.");
                return;
            }

            double totalHours = user.Activities.Sum(a => a.Duration.TotalMinutes) / 60.0;

            var favActivity = user.Activities
                .GroupBy(a => a.GetType().Name)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault();

            Console.WriteLine("----- Global Stats -----");
            Console.WriteLine($"Total Time (all activities): {totalHours:F2} hours");
            Console.WriteLine($"Favorite Activity: {favActivity}");
        }




    }
}
