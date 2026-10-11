using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class SessionAssignmentRepository : GenericRepository<SessionAssignment>, ISessionAssignmentRepository
    {
        public SessionAssignmentRepository(AppDbContext context) : base(context) { }
    }
}
