using CourseManagementSystem.Domain.Enums;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a Student user role, linking to the ApplicationUser.
    // Contains student-specific information like academic level and enrollments.
    public class Student : BaseEntity
    {
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        // The current academic level of the student (e.g., Grade 10, University Year 1).
        public AcademicLevel Level { get; set; } // AcademicLevel is an enum


        // Navigation property for all attendance records for this student.
        public virtual ICollection<StudentAttendance> Attendances { get; set; } = new List<StudentAttendance>();


        // Navigation property linking the student to their parents (via StudentParent join table).
        public virtual ICollection<StudentParent> Parents { get; set; } = new List<StudentParent>();


        // Navigation property for all class enrollments for this student.
        public virtual ICollection<StudentEnrollment> Enrollments { get; set; } = new List<StudentEnrollment>();


        // Navigation property for all assignment submissions made by this student.
        public virtual ICollection<StudentSubmission> Submissions { get; set; } = new List<StudentSubmission>();


        // Navigation property for all quiz attempts made by this student.
        public virtual ICollection<StudentQuizAttempt> QuizAttempts { get; set; } = new List<StudentQuizAttempt>();
    }
}
