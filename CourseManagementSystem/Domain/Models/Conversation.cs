namespace CourseManagementSystem.Domain.Models
{
    // Represents a private conversation between two or more users.
    public class Conversation : BaseEntity
    {
        // Navigation property for all users participating in this conversation.
        public virtual ICollection<ApplicationUser> Participants { get; set; }


        // Navigation property for all messages sent in this conversation.
        public virtual ICollection<Message> Messages { get; set; }
    }
}
