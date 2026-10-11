namespace CourseManagementSystem.Domain.Models
{
    /// Join table linking a specific Session to an Assignment.
    /// This creates a "due item" (e.g., "Homework 1" is due in "Week 3 Session").
    public class SessionAssignment : BaseEntity
    {
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }
        public int AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; }
        public DateTime Deadline { get; set; }
    }
}
