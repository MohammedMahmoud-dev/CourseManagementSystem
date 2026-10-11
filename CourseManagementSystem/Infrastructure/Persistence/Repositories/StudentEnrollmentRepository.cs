using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class StudentEnrollmentRepository : GenericRepository<StudentEnrollment>, IStudentEnrollmentRepository
    {
        public StudentEnrollmentRepository(AppDbContext context) : base(context) { }
    }
}
