namespace CourseManagementSystem.Domain.Models
{
    // Join table linking a StudentQuizAnswer to selected Choices.
    public class StudentQuizAnswerChoice : BaseEntity
    {
        public int StudentQuizAnswerId { get; set; }
        public virtual StudentQuizAnswer StudentQuizAnswer { get; set; }

        public int ChoiceId { get; set; }
        public virtual Choice Choice { get; set; }

    }
}
