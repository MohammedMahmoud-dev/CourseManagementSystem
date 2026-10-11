using CourseManagementSystem.Application.Contracts.Persistence;
using CourseManagementSystem.Domain.Models;
using CourseManagementSystem.Infrastructure.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CourseManagementSystem.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        // Protected so derived classes (like StudentRepository) can access it
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;
        //DbSet<T> is the gateway to database table ✅ (best choice for repositories)
        //✅ Can still apply.Where(...), .Include(...), .OrderBy(...)
        //✅ SQL is executed only when necessary(ToListAsync(), FindAsync())
        //✅ More efficient & professional approach
        //List<T> is just a static snapshot in RAM ❌ (expensive, not flexible)
        //❌ This has already executed the SQL query immediately
        //❌ It loads the entire table into memory
        //❌ You cannot append.Where(...) and expect it to run SQL — it stays in memory only

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task addAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            // Note: SaveChanges is NOT called here. The Unit of Work does that.        }
        }
        public async Task<IReadOnlyList<T>> findAsync(Expression<Func<T, bool>> expression)
        {
            // Use the predicate to filter results
            return await _context.Set<T>().Where(expression).AsNoTracking().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> getAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> getByIdAsync(int id)
        {
            // FindAsync is optimized for finding by primary key
            return await _context.Set<T>().FindAsync(id);
        }

        public void Remove(T entity)
        {
            // This just marks the entity as 'Deleted'
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            // This just marks the entity as 'Modified'
            _context.Entry(entity).State = EntityState.Modified;
            // It doesn’t yet remove the record from the database
            // it only changes the entity’s tracking state to Deleted inside EF’s change tracker.
            // 👉 The real delete happens when you call: await _context.SaveChangesAsync();
        }
    }
}
