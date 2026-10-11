using CourseManagementSystem.Domain.Models;

namespace CourseManagementSystem.Application.Contracts.Persistence
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        // Example: A method to get a student AND his enrollments
        Task<Student?> GetStudentWithEnrollmentsAsync(int studentId);


        // Example: Find a student by their user ID (from ASP.NET Identity)
        Task<Student?> GetStudentByApplicationUserIdAsync(string applicationUserId);
    }
}
