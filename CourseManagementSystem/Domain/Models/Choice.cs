using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a single answer choice for a multiple-choice Question.
    public class Choice : BaseEntity
    {
        // The text of the answer choice (e.g., "Paris").
        [MaxLength(1000)]
        public string Text { get; set; }

        // Flag indicating if this is the correct answer choice.
        public bool IsCorrect { get; set; }

        // Foreign key for the question this choice belongs to.
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }

}
