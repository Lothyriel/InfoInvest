namespace Core.Model
{
    public interface IRepository<T> where T : Entity
    {
        public T? GetById(Guid id);
        public List<T> GetRange(int start, int end);
        public void Add(T entity);
    }
}