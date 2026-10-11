using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a single message within a Conversation.
    public class Message : BaseEntity
    {
        // The text content of the message.
        [MaxLength(4000)]
        public string Content { get; set; }


        // Foreign key for the ApplicationUser who sent the message.
        public string? SenderId { get; set; }
        public virtual ApplicationUser Sender { get; set; }


        // Foreign key for the conversation this message belongs to.
        public int ConversationId { get; set; }
        public virtual Conversation Conversation { get; set; }
    }
}
