using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class AssistantRepository : GenericRepository<Assistant>, IAssistantRepository
    {
        public AssistantRepository(AppDbContext context) : base(context) { }
    }
}
