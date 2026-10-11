using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;

namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        IAnnouncementRepository _Announcement;
        IAssignmentRepository _Assignment;
        IAssistantRepository _Assistant;  
        IChoiceRepository _Choice;
        IClassGroupRepository _ClassGroup;
        IClassGroupAnnouncementRepository _ClassGroupAnnouncement;
        IConversationRepository _Conversation;
        IGradeItemRepository _GradeItem;
        IMaterialRepository _Material;
        IMessageRepository _Message;
        INotificationRepository _Notification;
        IPackageRepository _Package;
        IParentRepository _Parent;
        IPaymentRepository _Payment;
        IQuestionRepository _Question;
        IQuizRepository _Quiz;
        IScheduledTimeRepository _ScheduledTime;
        ISessionRepository _Session;
        ISessionAssignmentRepository _SessionAssignment;
        ISessionMaterialRepository _SessionMaterial;
        IStudentRepository _Student;
        IStudentAttendanceRepository _StudentAttendance;
        IStudentEnrollmentRepository _StudentEnrollment;
        ITeacherRepository _Teacher;
        IStudentParentRepository _StudentParent;
        IStudentSubmissionRepository _StudentSubmission;
        IStudentQuizAttemptRepository _StudentQuizAttempt;
        IStudentQuizAnswerRepository _StudentQuizAnswer;
        IStudentQuizAnswerChoiceRepository _StudentQuizAnswersChoice;
        ITeacherSubscriptionRepository _TeacherSubscription;
        IUserNotificationRepository _UserNotification;

        public IAnnouncementRepository AnnouncementRepository =>
            _Announcement ??= new AnnouncementRepository(_context);

        public IAssignmentRepository AssignmentRepository =>
            _Assignment ??= new AssignmentRepository(_context);

        public IAssistantRepository AssistantRepository =>
            _Assistant ??= new AssistantRepository(_context);

        public IChoiceRepository ChoiceRepository =>
            _Choice ??= new ChoiceRepository(_context);

        public IClassGroupRepository ClassGroupRepository =>
            _ClassGroup ??= new ClassGroupRepository(_context);

        public IClassGroupAnnouncementRepository ClassGroupAnnouncementRepository =>
            _ClassGroupAnnouncement ??= new ClassGroupAnnouncementRepository(_context);

        public IConversationRepository ConversationRepository =>
            _Conversation ??= new ConversationRepository(_context);

        public IGradeItemRepository GradeItemRepository =>
            _GradeItem ??= new GradeItemRepository(_context);

        public IMaterialRepository MaterialRepository =>
            _Material ??= new MaterialRepository(_context);

        public IMessageRepository MessageRepository =>
            _Message ??= new MessageRepository(_context);

        public INotificationRepository NotificationRepository =>
            _Notification ??= new NotificationRepository(_context);

        public IPackageRepository PackageRepository =>
            _Package ??= new PackageRepository(_context);

        public IParentRepository ParentRepository =>
            _Parent ??= new ParentRepository(_context);

        public IPaymentRepository PaymentRepository =>
            _Payment ??= new PaymentRepository(_context);

        public IQuestionRepository QuestionRepository =>
            _Question ??= new QuestionRepository(_context);

        public IQuizRepository QuizRepository =>
            _Quiz ??= new QuizRepository(_context);

        public IScheduledTimeRepository ScheduledTimeRepository =>
            _ScheduledTime ??= new ScheduledTimeRepository(_context);

        public ISessionRepository SessionRepository =>
            _Session ??= new SessionRepository(_context);

        public ISessionAssignmentRepository SessionAssignmentRepository =>
            _SessionAssignment ??= new SessionAssignmentRepository(_context);

        public ISessionMaterialRepository SessionMaterialRepository =>
            _SessionMaterial ??= new SessionMaterialRepository(_context);

        public IStudentRepository StudentRepository =>
            _Student ??= new StudentRepository(_context);

        public IStudentAttendanceRepository StudentAttendanceRepository =>
            _StudentAttendance ??= new StudentAttendanceRepository(_context);

        public IStudentEnrollmentRepository StudentEnrollmentRepository =>
            _StudentEnrollment ??= new StudentEnrollmentRepository(_context);

        public ITeacherRepository TeacherRepository =>
            _Teacher ??= new TeacherRepository(_context);

        public IStudentParentRepository StudentParentRepository =>
            _StudentParent ??= new StudentParentRepository(_context);

        public IStudentSubmissionRepository StudentSubmissionRepository =>
            _StudentSubmission ??= new StudentSubmissionRepository(_context);

        public IStudentQuizAttemptRepository StudentQuizAttemptRepository =>
            _StudentQuizAttempt ??= new StudentQuizAttemptRepository(_context);

        public IStudentQuizAnswerRepository StudentQuizAnswerRepository =>
            _StudentQuizAnswer ??= new StudentQuizAnswerRepository(_context);

        public IStudentQuizAnswerChoiceRepository StudentQuizAnswerChoiceRepository =>
            _StudentQuizAnswersChoice ??= new StudentQuizAnswerChoiceRepository(_context);

        public ITeacherSubscriptionRepository TeacherSubscriptionRepository =>
            _TeacherSubscription ??= new TeacherSubscriptionRepository(_context);

        public IUserNotificationRepository UserNotificationRepository =>
            _UserNotification ??= new UserNotificationRepository(_context);

        public IStudentQuizAnswerChoiceRepository StudentQuizAnswersChoiceRepository =>
            _StudentQuizAnswersChoice??= new StudentQuizAnswerChoiceRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}
