using CourseManagementSystem.Domain.Enums;
using CourseManagementSystem.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CourseManagementSystem.Infrastructure.Persistence.DatabaseContext
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<ClassGroup> ClassGroups { get; set; }
        public DbSet<ClassGroupAnnouncement> ClassGroupAnnouncements { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<GradeItem> GradeItems { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<ScheduledTime> ScheduledTimes { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SessionAssignment> SessionAssignments { get; set; }
        public DbSet<SessionMaterial> SessionMaterials { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAttendance> StudentAttendances { get; set; }
        public DbSet<StudentEnrollment> StudentEnrollments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentParent> StudentParents { get; set; }
        public DbSet<StudentSubmission> StudentSubmissions { get; set; }
        public DbSet<StudentQuizAttempt> StudentQuizAttempts { get; set; }
        public DbSet<StudentQuizAnswer> StudentQuizAnswers { get; set; }
        public DbSet<StudentQuizAnswerChoice> StudentQuizAnswersChoices { get; set; }
        public DbSet<TeacherSubscription> TeacherSubscriptions { get; set; }
        public DbSet<UserNotification> UserNotifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //in this for we are applying global query filter to all entities that inherit from BaseEntity
            //to exclude soft deleted entities from all queries
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // Check if the entity inherits from BaseEntity
                if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
                {
                    // Create the expression: e => !e.IsDeleted
                    var parameter = Expression.Parameter(entityType.ClrType, "e");
                    var propertyMethod = Expression.Property(parameter, nameof(BaseEntity.IsDeleted));
                    var compareExpression = Expression.Equal(propertyMethod, Expression.Constant(false));

                    var lambda = Expression.Lambda(compareExpression, parameter);

                    modelBuilder.Entity(entityType.ClrType)
                        .HasQueryFilter(lambda);
                }
            }

            modelBuilder.Entity<Announcement>(b =>
            {
                b.Property(a => a.Content).HasColumnType("nvarchar(max)");
                
            });
            modelBuilder.Entity<Assistant>(b =>
            {
                // Makes the ApplicationUserId a unique key
                b.HasIndex(a => a.ApplicationUserId).IsUnique();
            });

            modelBuilder.Entity<ClassGroup>(b =>
            {
                b.Property(cg => cg.Level).HasConversion<string>();
            });
            modelBuilder.Entity<ClassGroupAnnouncement>()
                        .HasIndex(cga => new { cga.ClassGroupId, cga.AnnouncementId })
                        .IsUnique();

            modelBuilder.Entity<Material>(b =>
            {
                b.Property(m => m.FileType).HasConversion<string>();
                
            });
            modelBuilder.Entity<Notification>()
                        .Property(n => n.Type)
                        .HasConversion<string>();
            modelBuilder.Entity<Package>()
                        .HasIndex(p => p.Name)
                        .IsUnique();
            modelBuilder.Entity<Parent>()
                        .HasIndex(p => p.ApplicationUserId)
                        .IsUnique();
            modelBuilder.Entity<Payment>(b =>
            {
                b.Property(p => p.Status).HasConversion<string>();
                // Transaction IDs must be unique
                b.HasIndex(p => p.GatewayTransactionId).IsUnique();
            });
            modelBuilder.Entity<Question>(b =>
            {
                b.Property(q => q.Type).HasConversion<string>();
            });
            modelBuilder.Entity<Quiz>(b =>
            {
                b.Property(q => q.Mode)
                 .HasConversion<string>()
                 .HasDefaultValue(QuizMode.Online);
                // Check constraint: Deadline must be after StartTime
                b.ToTable(t => t.HasCheckConstraint("CK_Quiz_DeadlineAfterStart", "[Deadline] > [StartTime]"));
            });
            modelBuilder.Entity<ScheduledTime>()
                        .HasIndex(st => new { st.ClassGroupId, st.Day, st.StartTime })
                        .IsUnique();
            modelBuilder.Entity<SessionAssignment>()
                        .HasIndex(sa => new { sa.SessionId, sa.AssignmentId })
                        .IsUnique();

            modelBuilder.Entity<SessionMaterial>()
                        .HasIndex(sm => new { sm.SessionId, sm.MaterialId })
                        .IsUnique();
            modelBuilder.Entity<Student>(b =>
            {
                b.HasIndex(s => s.ApplicationUserId).IsUnique();
                b.Property(s => s.Level).HasConversion<string>();
            });
            modelBuilder.Entity<StudentAttendance>(b =>
            {
                b.HasIndex(sa => new { sa.StudentId, sa.SessionId }).IsUnique();
                b.Property(sa => sa.Status).HasConversion<string>();
            });
            modelBuilder.Entity<StudentEnrollment>()
                        .HasIndex(se => new { se.StudentId, se.ClassGroupId })
                        .IsUnique();
            modelBuilder.Entity<StudentParent>(b =>
            {
                b.HasIndex(sp => new { sp.ParentId, sp.StudentId }).IsUnique();
                b.Property(sp => sp.RelationshipType).HasConversion<string>();
            });

            modelBuilder.Entity<StudentQuizAnswer>()
                        .HasIndex(sqa => new { sqa.StudentQuizAttemptId, sqa.QuestionId })
                        .IsUnique();
            modelBuilder.Entity<StudentQuizAnswerChoice>()
                        .HasIndex(sqac => new { sqac.StudentQuizAnswerId, sqac.ChoiceId })
                        .IsUnique();
            modelBuilder.Entity<StudentSubmission>(b =>
            {
                b.HasIndex(ss => new { ss.StudentId, ss.SessionAssignmentId }).IsUnique();
                b.Property(ss => ss.Status).HasConversion<string>();
            });
            modelBuilder.Entity<Teacher>()
                        .HasIndex(t => t.ApplicationUserId)
                        .IsUnique();

            modelBuilder.Entity<TeacherSubscription>(b =>
            {
                b.Property(ts => ts.Status).HasConversion<string>();
                b.HasIndex(ts => ts.PaymentReference).IsUnique();

                // Check constraint: EndDate must be after StartDate
                b.ToTable(t => t.HasCheckConstraint("CK_Subscription_EndDateAfterStart", "[EndDate] > [StartDate]"));
            });
            modelBuilder.Entity<UserNotification>(b =>
            {
                b.HasIndex(un => new { un.RecipientId, un.NotificationId }).IsUnique();
            });
        }



    }
}
