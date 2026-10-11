namespace CourseManagementSystem.Domain.Models
{
    public class SessionQuiz : BaseEntity
    {
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
