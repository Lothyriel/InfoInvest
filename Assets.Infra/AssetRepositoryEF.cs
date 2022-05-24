using Assets.Model;

namespace Assets.Infra
{
    public class AssetRepositoryEF : RepositoryEF<Asset>, IAssetRepository
    {
        public AssetRepositoryEF(AssetsDbContext context) : base(context)
        {
        }
    }
}