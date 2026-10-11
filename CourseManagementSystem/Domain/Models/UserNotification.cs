namespace CourseManagementSystem.Domain.Models
{
    // Join table linking a Notification to a recipient ApplicationUser.
    // This also tracks the read status for that specific user.
    public class UserNotification : BaseEntity
    {
        // Foreign key for the user receiving the notification.
        public string RecipientId { get; set; }
        public virtual ApplicationUser Recipient { get; set; }


        // Foreign key for the notification being sent.
        public int NotificationId { get; set; }
        public Notification Notification { get; set; }


        // Flag indicating if the notification has been read (though this is often tracked in UserNotification).
        public bool IsRead { get; set; } = false;


        // Timestamp when the notification was read.
        public DateTime? ReadAt { get; set; }
    }
}
