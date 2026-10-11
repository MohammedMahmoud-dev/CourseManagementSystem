using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.Repositories;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementSystem.Application.Features.Students.Commands.RegisterStudent
{
    public class RegisterStudentHandler : IRequestHandler<RegisterStudentCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<ApplicationUser> _userManager;
        public RegisterStudentHandler(IUnitOfWork unitOfWork, UserManager<ApplicationUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task<int> Handle(RegisterStudentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // 2. Create the Identity User
                var user = new ApplicationUser
                {
                    UserName = request.Email,
                    Email = request.Email,
                    FullName = request.FullName,
                    PhoneNumber = request.PhoneNumber
                };

                var identityResult = await _userManager.CreateAsync(user, request.Password);

                if (!identityResult.Succeeded)
                {
                    // Collect errors and throw exception (Implement a custom Exception for cleaner API responses)
                    var errors = string.Join(", ", identityResult.Errors.Select(e => e.Description));
                    throw new Exception($"User registration failed: {errors}");
                }

                // 3. Assign Role
                await _userManager.AddToRoleAsync(user, "Student");

                // 4. Create the Student Entity
                var student = new Student
                {
                    ApplicationUserId = user.Id, // Link the Foreign Key
                    Level = request.Level,
                    CreatedAt = DateTime.UtcNow,
                };

                await _unitOfWork.StudentRepository.addAsync(student);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                // 5. Commit Transaction

                return student.Id;
            }
            catch
            {
                throw;
            }
        }
    }
}
