using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class StudentQuizAnswerChoiceRepository : GenericRepository<StudentQuizAnswerChoice>, IStudentQuizAnswerChoiceRepository
    {
        public StudentQuizAnswerChoiceRepository(AppDbContext context) : base(context) { }
    }
}
