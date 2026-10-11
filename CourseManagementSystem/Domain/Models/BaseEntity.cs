namespace CourseManagementSystem.Domain.Models
{
    // An abstract base class that provides common properties for all entities.
    // This includes tracking for ID, creation, update, and soft deletion.
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        // Flag to indicate if the entity is active and usable in the system.
        // (a disabled class, a banned user).
        public bool IsActive { get; set; } = true;

        // Flag to indicate if the entity has been soft deleted.
        // Often used in conjunction with DeletedAt.
        public bool IsDeleted { get; set; } = false;
    }
}
