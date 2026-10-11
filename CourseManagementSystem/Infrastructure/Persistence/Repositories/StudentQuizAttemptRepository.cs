using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class StudentQuizAttemptRepository : GenericRepository<StudentQuizAttempt>, IStudentQuizAttemptRepository
    {
        public StudentQuizAttemptRepository(AppDbContext context) : base(context) { }
    }
}
