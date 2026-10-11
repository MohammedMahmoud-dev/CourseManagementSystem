using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    // Inherit from GenericRepository<Student> and implement IStudentRepository
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        // We still need the context, so we inject it to the base (GenericRepository) constructor
        public StudentRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<Student?> GetStudentByApplicationUserIdAsync(string applicationUserId)
        {
            return await _context.Students
                            .FirstOrDefaultAsync(s => s.ApplicationUserId == applicationUserId);
        }

        public async Task<Student?> GetStudentWithEnrollmentsAsync(int studentId)
        {
            return await _context.Students
                            .Include(s => s.Enrollments) // Eagerly load enrollments
                            .ThenInclude(e => e.ClassGroup) // Also load the class group for each enrollment
                            .FirstOrDefaultAsync(s => s.Id == studentId);
        }
    }
}
