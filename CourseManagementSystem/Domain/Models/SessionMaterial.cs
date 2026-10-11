namespace CourseManagementSystem.Domain.Models
{
    // Join table linking a Session to a Material.
    // Represents the many-to-many relationship between sessions and materials.
    public class SessionMaterial : BaseEntity
    {
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
    }
}
