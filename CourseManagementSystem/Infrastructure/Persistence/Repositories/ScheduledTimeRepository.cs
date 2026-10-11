using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class ScheduledTimeRepository : GenericRepository<ScheduledTime>, IScheduledTimeRepository
    {
        public ScheduledTimeRepository(AppDbContext context) : base(context) { }
    }
    
}
