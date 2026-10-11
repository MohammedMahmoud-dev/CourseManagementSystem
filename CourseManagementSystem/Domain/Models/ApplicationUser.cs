using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(250)]
        public string FullName { get; set; }

        // Navigation property for the notifications intended for this user.
        public virtual ICollection<UserNotification> Notifications { get; set; } = new List<UserNotification>();
    }
}
