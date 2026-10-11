using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class TeacherSubscriptionRepository : GenericRepository<TeacherSubscription>, ITeacherSubscriptionRepository
    {
        public TeacherSubscriptionRepository(AppDbContext context) : base(context) { }
    }
}
