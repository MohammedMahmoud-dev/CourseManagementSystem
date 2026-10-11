using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class AssignmentRepository : GenericRepository<Assignment> , IAssignmentRepository
    {
        public AssignmentRepository(AppDbContext context) : base(context) { }
    }
}
