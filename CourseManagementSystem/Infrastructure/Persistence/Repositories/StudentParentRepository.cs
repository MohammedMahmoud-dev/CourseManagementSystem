using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class StudentParentRepository : GenericRepository<StudentParent>, IStudentParentRepository
    {
        public StudentParentRepository(AppDbContext context) : base(context) { }
    }
}
