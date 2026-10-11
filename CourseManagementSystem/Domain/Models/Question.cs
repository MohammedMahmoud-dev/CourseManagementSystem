using CourseManagementSystem.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    /// Represents a single question within a Quiz.
    public class Question : BaseEntity
    {
        // The text of the question.
        [MaxLength(4000)]
        public string Text { get; set; }

        // The type of question (e.g., MultipleChoice, TrueFalse, ShortAnswer).
        public QuestionType Type { get; set; } // QuestionType is an enum

        /// The number of points this question is worth.
        [Range(0, 100)]
        public int Points { get; set; } = 1;

        // Foreign key for the quiz this question belongs to.
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }

        // Navigation property for the answer choices (if it's a multiple-choice question).
        public virtual ICollection<Choice> Choices { get; set; } = new List<Choice>();
    }
}
