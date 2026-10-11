using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class ConversationRepository : GenericRepository<Conversation>, IConversationRepository
    {
        public ConversationRepository(AppDbContext context) : base(context) { }
    }

}
