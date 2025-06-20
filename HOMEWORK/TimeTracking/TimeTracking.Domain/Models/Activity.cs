using TimeTracking.Domain.Enums;

namespace TimeTracking.Domain.Models
{
    public class Activity
    {
        public ActivityType Type { get; set; }
        public TimeSpan Duration { get; set; }
        public string ExtraInfo { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
