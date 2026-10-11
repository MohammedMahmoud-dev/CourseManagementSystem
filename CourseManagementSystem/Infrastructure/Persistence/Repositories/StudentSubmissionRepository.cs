using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class StudentSubmissionRepository : GenericRepository<StudentSubmission>, IStudentSubmissionRepository
    {
        public StudentSubmissionRepository(AppDbContext context) : base(context) { }
    }
}
