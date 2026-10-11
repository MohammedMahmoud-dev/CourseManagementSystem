using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class StudentQuizAnswerRepository : GenericRepository<StudentQuizAnswer>, IStudentQuizAnswerRepository
    {
        public StudentQuizAnswerRepository(AppDbContext context) : base(context) { }
    }
}
