using Users.Model.Client;

namespace Core.Infra.RepositoresEF
{
    public class ClientRepositoryEF : RepositoryEF<Client>, IClientRepository
    {
        public ClientRepositoryEF(InfoInvestDbContext context) : base(context)
        {
        }
    }
}