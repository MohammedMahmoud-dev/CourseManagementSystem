namespace CourseManagementSystem.Domain.Models
{
    // Represents a Parent user role, linking to the ApplicationUser.
    // Parents are linked to one or more Student entities.
    public class Parent : BaseEntity
    {
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }


        // Navigation property linking this parent to their children (via StudentParent join table).
        public virtual ICollection<StudentParent> Children { get; set; } = new List<StudentParent>();
    }
}
