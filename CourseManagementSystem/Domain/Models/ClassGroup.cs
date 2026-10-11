using CourseManagementSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a group or class taught by a teacher "Math 101 - Section A".
    // This is a central entity linking students, sessions, and announcements.
    public class ClassGroup : BaseEntity
    {
        [MaxLength(200)]
        public string Title { get; set; }


        // The maximum number of students allowed in this class. Nullable if no limit.
        [Range(1, 1000)]
        public int? MaxCapacity { get; set; }
        

        // The academic level this class is intended for.
        public AcademicLevel Level { get; set; } // AcademicLevel is an enum
        [MaxLength(500)]
        public string? Description { get; set; }


        // Navigation property for all individual sessions (lectures, labs) belonging to this class.
        public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();


        // Navigation property linking to the students enrolled in this class (via StudentEnrollment join table).
        public virtual ICollection<StudentEnrollment> Students { get; set; } = new HashSet<StudentEnrollment>();


        // Navigation property for all announcements posted to this class.
        public virtual ICollection<ClassGroupAnnouncement> Announcements { get; set; } = new List<ClassGroupAnnouncement>();


        // Foreign key for the teacher who manages this class.
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        // Navigation property for the recurring weekly schedule for this class (e.g., "Mondays at 10:00").
        public virtual ICollection<ScheduledTime> ScheduledTimes { get; set; } = new List<ScheduledTime>();
    }

}
