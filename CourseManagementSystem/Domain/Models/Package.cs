using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a subscription package a teacher can purchase (e.g., "Basic", "Pro").
    // Defines features, price, and duration.
    public class Package : BaseEntity
    {
        // The name of the package (e.g., "Pro Tier").
        [MaxLength(100)]
        public string Name { get; set; }


        // A description of the features included in the package.
        [MaxLength(500)]
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 99999.99)]
        public decimal Price { get; set; }


        // The duration of the subscription in days.
        [Range(1, 365)] // 1 day to 10 years
        public int DurationInDays { get; set; }


        // The maximum number of students the teacher can manage under this plan.
        [Range(50, 100000)]
        public int MaxStudents { get; set; }


        // Navigation property for all subscriptions that have been made for this package.
        public virtual ICollection<TeacherSubscription> Subscriptions { get; set; } = new List<TeacherSubscription>();
    }

}
