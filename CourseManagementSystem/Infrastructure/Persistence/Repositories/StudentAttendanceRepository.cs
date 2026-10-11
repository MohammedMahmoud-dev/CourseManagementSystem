using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class StudentAttendanceRepository : GenericRepository<StudentAttendance>, IStudentAttendanceRepository
    {
        public StudentAttendanceRepository(AppDbContext context) : base(context) { }
    }
}
