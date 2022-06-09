using Assets.Model;
using Core.Infra.MongoDB;

namespace Assets.Infra
{
    public class AssetMongoRepository : MongoRepository<Asset>, IAssetRepository
    {
        public AssetMongoRepository(string connectionString) : base(connectionString)
        {
        }

        protected override string CollectionName { get; } = "AssetsCollection";
    }
}