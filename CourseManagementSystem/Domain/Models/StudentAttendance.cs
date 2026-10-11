using CourseManagementSystem.Domain.Enums;

namespace CourseManagementSystem.Domain.Models
{
    // Records a student's attendance status for a specific session.
    public class StudentAttendance : BaseEntity
    {
        // Foreign key for the student.
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }


        // Foreign key for the session.
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }

        // The student's status (Present, Absent, Late).
        public AttendanceStatus Status { get; set; } // AttendanceStatus is an enum
    }
}
