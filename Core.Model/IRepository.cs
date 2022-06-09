namespace Core.Model
{
    public interface IRepository<T> where T : Entity
    {
        public Task<T?> GetById(Guid id);
        public Task<List<T>> GetRange(int start, int end);
        public Task Add(T entity);
    }
}