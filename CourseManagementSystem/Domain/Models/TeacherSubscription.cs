using CourseManagementSystem.Domain.Enums;

namespace CourseManagementSystem.Domain.Models
{
    /// <summary>
    /// Represents an active or past subscription a teacher has to a Package.
    /// </summary>
    public class TeacherSubscription : BaseEntity
    {

        public int? TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        // Foreign key for the package that was purchased.
        public int? PackageId { get; set; }
        public virtual Package Package { get; set; }

        // The date and time the subscription becomes active.
        public DateTime StartDate { get; set; }

        // The date and time the subscription expires.
        public DateTime EndDate { get; set; }

        // A reference string from the payment gateway (e.g., an invoice ID).

        public string PaymentReference { get; set; }
        public SubscriptionStatus Status { get; set; } // SubscriptionStatus is an enum
    }
}
