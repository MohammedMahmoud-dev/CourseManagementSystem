using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class GradeItemRepository : GenericRepository<GradeItem>, IGradeItemRepository
    {
        public GradeItemRepository(AppDbContext context) : base(context) { }
    }
}
