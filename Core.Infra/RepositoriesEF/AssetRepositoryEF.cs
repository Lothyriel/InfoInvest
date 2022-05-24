using Assets;
using Assets.Model;

namespace Core.Infra.RepositoresEF
{
    public class AssetRepositoryEF : RepositoryEF<Asset>, IAssetRepository
    {
        public AssetRepositoryEF(InfoInvestDbContext context) : base(context)
        {
        }
    }
}