using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Domain.Models
{
    // Represents a component of the final grade for a ClassGroup (e.g., "Homework", "Quizzes").
    // it be linked directly to an assignment or quiz.
    public class GradeItem : BaseEntity
    {
        // The name of the grade item (e.g., "Midterm Exam").
        [MaxLength(150)]
        public string Title { get; set; }


        // The maximum points possible for this item.
        [Range(1, 1000)]
        public int MaxPoints { get; set; }


        // The weight of this item in the final grade calculation (e.g., 0.2 for 20%).
        [Range(0.0, 1.0)]
        public double Weight { get; set; } = 1.0;


        // Foreign key for the class group this grade item belongs to.
        public int ClassGroupId { get; set; }
        public virtual ClassGroup ClassGroup { get; set; }


        // Optional foreign key if this grade item is linked to a SessionAssignment.
        public int? SessionAssignmentId { get; set; }
        public virtual SessionAssignment SessionAssignment { get; set; }


        // Optional foreign key if this grade item is linked to a Quiz.
        public int? QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
