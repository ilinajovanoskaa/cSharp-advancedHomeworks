using System.Data;
using TimeTracking.Domain.Models;
using TimeTracking.Domain.Enums;
using TimeTracking.Services.Enums;

namespace TimeTracking.Services.Abstractions.Interfaces
{
    public interface IUIService
    {
        MainMenuChoice ShowMainMenu();
        ActivityType ChooseActivity();
        string GetExtraInfo(ActivityType activity);
        void TrackActivity();
        void ShowStatistics(User user);
        void ShowReadingStats(User user);
        void ShowExerciseStats(User user);
        void ShowWorkingStats(User user);
        void ShowHobbiesStats(User user);
        void ShowGlobalStats(User user);

    }
}
