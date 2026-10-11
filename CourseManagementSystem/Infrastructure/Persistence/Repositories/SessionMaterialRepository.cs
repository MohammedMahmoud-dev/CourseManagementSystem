using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class SessionMaterialRepository : GenericRepository<SessionMaterial>, ISessionMaterialRepository
    {
        public SessionMaterialRepository(AppDbContext context) : base(context) { }
    }
}
