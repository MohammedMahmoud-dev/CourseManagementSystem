using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models                                          
{
    // Represents a generic announcement that can be posted by a Teacher Or Assistant.
    public class Announcement : BaseEntity
    {
        // Foreign key for the ApplicationUser who created this announcement.
        public string CreatorUserId { get; set; }

        public ApplicationUser CreatorUser { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }


        // The main content/body of the announcement.
        public string Content { get; set; }


        // Navigation property for all class group announcements associated with this announcement.
        public virtual Collection<ClassGroupAnnouncement> ClassGroupAnnouncements { get; set; } = new Collection<ClassGroupAnnouncement>();
    }
}
