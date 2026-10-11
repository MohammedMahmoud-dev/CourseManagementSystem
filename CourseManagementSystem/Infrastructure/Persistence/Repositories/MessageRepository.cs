using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class MessageRepository :GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(AppDbContext context) : base(context) { }
    }
}
