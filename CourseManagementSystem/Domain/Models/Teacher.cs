namespace CourseManagementSystem.Domain.Models
{
    // Represents a Teacher user role, linking to the ApplicationUser.
    // Contains teacher-specific information like office number and their associated classes.
    public class Teacher : BaseEntity
    {
        //The teacher's office room number. Nullable if they don't have one.
        public int? OfficeNumber { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public string ApplicationUserId { get; set; }

        // Navigation property for all ClassGroups managed by this teacher.
        public virtual ICollection<ClassGroup> ClassGroups { get; set; }

        // Navigation property for all Assistants assigned to help this teacher.
        public virtual ICollection<Assistant> Assistants { get; set; }
    }
}
