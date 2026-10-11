using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a template for an assignment (e.g., "Homework 1").
    // This is the definition, not the student's submission.
    public class Assignment : BaseEntity
    {
        // Foreign key for the ApplicationUser who created this assignment.
        public string CreatorUserId { get; set; }
        public ApplicationUser CreatorUser { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }

        // An optional file path for assignment resources (e.g., a worksheet).
        [MaxLength(1024)]
        public string? FilePath { get; set; }
        [Range(1, 1000)]
        public int? MaxPoints { get; set; }
    }
}
