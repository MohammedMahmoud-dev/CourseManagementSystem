using CourseManagementSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a student's submission for a specific SessionAssignment.
    public class StudentSubmission : BaseEntity
    {
        // Foreign key for the student who made the submission.
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }


        // Foreign key for the specific assignment instance this submission is for.
        public int SessionAssignmentId { get; set; }
        public virtual SessionAssignment SessionAssignment { get; set; }

        // The grade or score given by the teacher.
        [Range(0, 1000)] // Assuming grade range
        public int? Grade { get; set; }


        // The timestamp when the student submitted their work.
        public DateTime SubmittedDate { get; set; } = DateTime.Now;


        // Optional comments or feedback from the teacher.
        [MaxLength(4000)]
        public string? TeacherComments { get; set; }


        // The file path for the student's submitted work.
        [MaxLength(1024)]
        public string FilePath { get; set; }


        // The status of the submission (e.g., Submitted, Graded, Late).
        public SubmissionStatus Status { get; set; } // SubmissionStatus is an enum
    }
}
