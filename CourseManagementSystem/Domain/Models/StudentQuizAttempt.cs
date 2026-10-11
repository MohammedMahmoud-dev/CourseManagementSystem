using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{

    /// Represents a student's single attempt at taking a Quiz.
    public class StudentQuizAttempt : BaseEntity
    {
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }


        // The final score the student received on this attempt.
        [Range(0, 10000)] // Assuming score can't be negative
        public int Score { get; set; }

        public DateTime? SubmittedAt { get; set; }


        /// Navigation property for all the answers given by the student in this attempt.
        public virtual ICollection<StudentQuizAnswer> Answers { get; set; } = new List<StudentQuizAnswer>();
    }

}
