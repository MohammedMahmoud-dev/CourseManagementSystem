using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class ClassGroupRepository : GenericRepository<ClassGroup>, IClassGroupRepository
    {
        public ClassGroupRepository(AppDbContext context) : base(context) { }
    }
}
