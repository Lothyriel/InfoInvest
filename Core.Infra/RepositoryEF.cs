using Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.Infra
{
    public class RepositoryEF<T> : IRepository<T> where T : Entity
    {
        private readonly DbContext _context;

        public RepositoryEF(DbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public T? GetById(Guid id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetRange(int start, int end)
        {
            return _context.Set<T>().Skip(start).Take(end).ToList();
        }
    }
}