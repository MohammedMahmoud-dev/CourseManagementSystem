using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class PackageRepository :GenericRepository<Package>, IPackageRepository
    {
        public PackageRepository(AppDbContext context) : base(context) { }
    }
}
