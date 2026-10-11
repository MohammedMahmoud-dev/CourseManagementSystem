using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a single class meeting or lecture (e.g., "Week 1 - Intro").
    // This is where materials, assignments, and attendance are linked.
    public class Session : BaseEntity
    {
        [MaxLength(4000)]
        public string? Description { get; set; }

        /// Foreign key for the class group this session belongs to.
        public int ClassGroupId { get; set; }
        public virtual ClassGroup ClassGroup { get; set; }

        public virtual ICollection<SessionMaterial> Materials { get; set; } = new List<SessionMaterial>();

        public virtual ICollection<SessionAssignment> Assignments { get; set; } = new List<SessionAssignment>();
        public virtual ICollection<SessionQuiz> Quizzes { get; set; } = new List<SessionQuiz>();
        // Navigation property for all student attendance records for this session.
        public virtual ICollection<StudentAttendance> Attendances { get; set; } = new List<StudentAttendance>();
    }

}
