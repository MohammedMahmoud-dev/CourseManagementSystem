namespace CourseManagementSystem.Domain.Models
{
    // Join table linking a ClassGroup to an Announcement.
    // This posts the announcement to the class's feed.
    public class ClassGroupAnnouncement : BaseEntity
    {
        // Foreign key for the class group receiving the announcement.
        public int ClassGroupId { get; set; }
        public virtual ClassGroup ClassGroup { get; set; }


        // Foreign key for the announcement being posted.
        public int AnnouncementId { get; set; }
        public virtual Announcement Announcement { get; set; }
    }
}
