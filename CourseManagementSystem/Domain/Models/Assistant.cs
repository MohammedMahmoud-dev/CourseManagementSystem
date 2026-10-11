namespace CourseManagementSystem.Domain.Models
{
    // Represents an Assistant user role, linked to both a core user and a teacher.
    // Assistants help teachers manage their classes.
    public class Assistant : BaseEntity
    {
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }


        // Foreign key for the teacher this assistant works for.
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
