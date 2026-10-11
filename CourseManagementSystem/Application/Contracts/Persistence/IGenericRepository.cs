using CourseManagementSystem.Domain.Models;
using System.Linq.Expressions;

namespace CourseManagementSystem.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> getAllAsync();
        Task<T?> getByIdAsync(int id);
        Task<IReadOnlyList<T>> findAsync(Expression<Func<T, bool>> expression);
            //Expression<Func<T, bool>> expression: It allows us to pass a lambda expression to filter data at runtime.
            //Instead of writing
            //FindStudentByEmail(string email)
            //FindStudentByPhone(string phone)
            //FindStudentByStatus(bool isActive)
            //await _studentRepository.FindAsync(s => s.Email == "test@gmail.com");
            //await _studentRepository.FindAsync(s => s.IsActive == true);
            //await _studentRepository.FindAsync(s => s.Age > 18);
            //EF Core needs Expression<> so it can convert to SQL instead of pulling entire table into memory.
        Task addAsync(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
