using CourseManagementSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    /// Represents a quiz associated with a specific session.
    public class Quiz : BaseEntity
    {
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string? Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Deadline { get; set; }
        [Range(1, 1000)]
        public int MaxPoints { get; set; }


        // The mode of the quiz (e.g., Online, InClass).
        public QuizMode Mode { get; set; } = QuizMode.Online; // Assuming QuizMode is an enum


        public virtual ICollection<SessionQuiz> Sessions { get; set; } = new List<SessionQuiz>();

        public virtual ICollection<Question> Questions { get; set; } = new List<Question>();


        // Navigation property for all student attempts on this quiz.
        public virtual ICollection<StudentQuizAttempt> Attempts { get; set; } = new List<StudentQuizAttempt>();
    }

}

