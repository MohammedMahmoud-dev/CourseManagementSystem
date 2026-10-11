namespace CourseManagementSystem.Domain.Models
{
    // Defines a single, recurring time slot for a ClassGroup.
    // (e.g., "Mondays from 10:00 AM for 90 minutes").
    public class ScheduledTime : BaseEntity
    {
        // The day of the week for this time slot.
        public DayOfWeek Day { get; set; }


        // The time of day the class starts.
        public TimeOnly StartTime { get; set; }


        // The duration of the class session.
        public TimeSpan Duration { get; set; }


        // Foreign key for the class group this schedule belongs to.
        public int ClassGroupId { get; set; }


        // Navigation property to the class group.
        public virtual ClassGroup ClassGroup { get; set; }
    }
}
