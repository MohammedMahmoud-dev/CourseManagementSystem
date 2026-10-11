namespace CourseManagementSystem.Domain.Models
{
    // Join table linking a Student to a ClassGroup.
    // Represents a student's enrollment in a class.
    public class StudentEnrollment : BaseEntity
    {
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int ClassGroupId { get; set; }
        public virtual ClassGroup ClassGroup { get; set; }
    }
}
