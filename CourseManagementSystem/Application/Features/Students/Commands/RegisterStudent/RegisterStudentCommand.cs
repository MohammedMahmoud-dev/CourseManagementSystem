using CourseManagementSystem.Domain.Enums;
using MediatR;

namespace CourseManagementSystem.Application.Features.Students.Commands.RegisterStudent
{
    public class RegisterStudentCommand : IRequest<int>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public AcademicLevel Level { get; set; } // e.g., Grade10, UniversityYear1
    }
}
