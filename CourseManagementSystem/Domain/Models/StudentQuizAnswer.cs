using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a student's answer to a single Question within a StudentQuizAttempt.
    public class StudentQuizAnswer : BaseEntity
    {
        // Foreign key for the quiz attempt this answer belongs to.
        public int StudentQuizAttemptId { get; set; }
        public virtual StudentQuizAttempt StudentQuizAttempt { get; set; }


        // Foreign key for the question being answered.
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }


        // The selected choices (for multiple choice questions).
        public virtual ICollection<StudentQuizAnswerChoice> SelectedChoices { get; set; } = new HashSet<StudentQuizAnswerChoice>();
        // The text answer (for short answer questions).
        [MaxLength(4000)]
        public string? ShortAnswerText { get; set; }


        // The boolean answer (for true/false questions).
        public bool? TrueFalseAnswer { get; set; }
    }

}
