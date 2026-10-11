using CourseManagementSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseManagementSystem.Domain.Models
{
    // Records a payment transaction, typically linked to a TeacherSubscription.
    public class Payment : BaseEntity
    {
        // The monetary amount that was paid.
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        /// The status of the payment (e.g., "Succeeded", "Failed").
        public PaymentStatus Status { get; set; } // PaymentStatus is an enum
        [MaxLength(50)]
        public string PaymentGateway { get; set; } //(e.g., "Stripe", "PayPal")

        /// <summary>
        /// The unique transaction ID from the payment processor (e.g., Stripe, PayPal).
        /// </summary>
        public string GatewayTransactionId { get; set; }

        /// <summary>
        /// Foreign key linking this payment to the subscription it was for.
        /// </summary>
        public int? TeacherSubscriptionId { get; set; }

        /// <summary>
        /// Navigation property to the subscription.
        /// </summary>
        public virtual TeacherSubscription TeacherSubscription { get; set; }
        
    }
}
