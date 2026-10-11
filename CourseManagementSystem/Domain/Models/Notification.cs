using CourseManagementSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a notification message to be sent to users.
    public class Notification : BaseEntity
    {


        // The content of the notification message.
        [MaxLength(1000)]
        public string Message { get; set; }





        // Navigation property linking to the recipients via the UserNotification join table.
        public ICollection<UserNotification> Recipients { get; set; } = new List<UserNotification>();


        // The type of notification (e.g., NewGrade, Announcement, System).
        public NotificationType Type { get; set; } // NotificationType is an enum


        // An optional URL to navigate to when the notification is clicked.
        [MaxLength(1024)] // For URLs
        public string? LinkUrl { get; set; }
    }

}
