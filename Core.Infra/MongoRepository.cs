using Core.Model;
using MongoDB.Driver;

namespace Core.Infra.MongoDB
{
    public abstract class MongoRepository<T> : IRepository<T> where T : Entity
    {
        public MongoRepository(string connectionString)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("InfoInvestDB");
            Collection = database.GetCollection<T>(CollectionName);
        }

        protected IMongoCollection<T> Collection { get; }
        protected abstract string CollectionName { get; }

        public async Task Add(T entity)
        {
            await Collection.InsertOneAsync(entity);
        }

        public async Task<T?> GetById(Guid id)
        {
            return await Collection.Find(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetRange(int start, int end)
        {
            return await Collection.Aggregate().Skip(start).Limit(end).ToListAsync();
        }
    }
}