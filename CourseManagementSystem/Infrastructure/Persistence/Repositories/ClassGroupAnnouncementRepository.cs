using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class ClassGroupAnnouncementRepository : GenericRepository<ClassGroupAnnouncement>, IClassGroupAnnouncementRepository
    {
        public ClassGroupAnnouncementRepository(AppDbContext context): base(context) { }
    }
}
