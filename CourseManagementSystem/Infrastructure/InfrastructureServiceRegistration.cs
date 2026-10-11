using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
using CourseManagementSystem.Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CourseManagementSystem.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // 1. Register DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))); // Get CS from appsettings.json

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            // 2. Register the Unit of Work and Repositories
            // AddScoped: A new instance is created for each web request
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // Register all repositories
            services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();
            services.AddScoped<IAssignmentRepository, AssignmentRepository>();
            services.AddScoped<IAssistantRepository, AssistantRepository>();
            services.AddScoped<IChoiceRepository, ChoiceRepository>();
            services.AddScoped<IClassGroupRepository, ClassGroupRepository>();
            services.AddScoped<IClassGroupAnnouncementRepository, ClassGroupAnnouncementRepository>();
            services.AddScoped<IConversationRepository, ConversationRepository>();
            services.AddScoped<IGradeItemRepository, GradeItemRepository>();
            services.AddScoped<IMaterialRepository, MaterialRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IPackageRepository, PackageRepository>();
            services.AddScoped<IParentRepository, ParentRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IQuizRepository, QuizRepository>();
            services.AddScoped<IScheduledTimeRepository, ScheduledTimeRepository>();
            services.AddScoped<ISessionRepository, SessionRepository>();
            services.AddScoped<ISessionAssignmentRepository, SessionAssignmentRepository>();
            services.AddScoped<ISessionMaterialRepository, SessionMaterialRepository>();
            services.AddScoped<IStudentAttendanceRepository, StudentAttendanceRepository>();
            services.AddScoped<IStudentEnrollmentRepository, StudentEnrollmentRepository>();
            services.AddScoped<IStudentParentRepository, StudentParentRepository>();
            services.AddScoped<IStudentSubmissionRepository, StudentSubmissionRepository>();
            services.AddScoped<IStudentQuizAttemptRepository, StudentQuizAttemptRepository>();
            services.AddScoped<IStudentQuizAnswerRepository, StudentQuizAnswerRepository>();
            services.AddScoped<IStudentQuizAnswerChoiceRepository, StudentQuizAnswerChoiceRepository>();
            services.AddScoped<ITeacherSubscriptionRepository, TeacherSubscriptionRepository>();
            services.AddScoped<IUserNotificationRepository, UserNotificationRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration["Jwt:Issuer"],
                    ValidAudience = configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(configuration["Jwt:Key"])
                    )
                };
            });


            return services;
        }
    }
}
