namespace CourseManagementSystem.Application.Contracts.Persistence
{
    // IDisposable is used to properly dispose of the DbContext
    public interface IUnitOfWork : IDisposable
    {
        IAnnouncementRepository AnnouncementRepository { get; }
        IAssignmentRepository AssignmentRepository { get; }
        IAssistantRepository AssistantRepository { get; }
        IChoiceRepository ChoiceRepository { get; }
        IClassGroupRepository ClassGroupRepository { get; }
        IClassGroupAnnouncementRepository ClassGroupAnnouncementRepository { get; }
        IConversationRepository ConversationRepository { get; }
        IGradeItemRepository GradeItemRepository { get; }
        IMaterialRepository MaterialRepository { get; }
        IMessageRepository MessageRepository { get; }
        INotificationRepository NotificationRepository { get; }
        IPackageRepository PackageRepository { get; }
        IParentRepository ParentRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        IQuestionRepository QuestionRepository { get; }
        IQuizRepository QuizRepository { get; }
        IScheduledTimeRepository ScheduledTimeRepository { get; }
        ISessionRepository SessionRepository { get; }
        ISessionAssignmentRepository SessionAssignmentRepository { get; }
        ISessionMaterialRepository SessionMaterialRepository { get; }
        IStudentRepository StudentRepository { get; }
        IStudentAttendanceRepository StudentAttendanceRepository { get; }
        IStudentEnrollmentRepository StudentEnrollmentRepository { get; }
        ITeacherRepository TeacherRepository { get; }
        IStudentParentRepository StudentParentRepository { get; }
        IStudentSubmissionRepository StudentSubmissionRepository { get; }
        IStudentQuizAttemptRepository StudentQuizAttemptRepository { get; }
        IStudentQuizAnswerRepository StudentQuizAnswerRepository { get; }
        IStudentQuizAnswerChoiceRepository StudentQuizAnswersChoiceRepository { get; }
        ITeacherSubscriptionRepository TeacherSubscriptionRepository { get; }
        IUserNotificationRepository UserNotificationRepository { get; }

        //CancellationToken is a struct used in asynchronous programming (async/await) to allow the caller to cancel a running task
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
