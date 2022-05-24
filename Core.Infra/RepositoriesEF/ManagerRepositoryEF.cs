using Users.Model.Manager;

namespace Core.Infra.RepositoresEF
{
    public class ManagerRepositoryEF : RepositoryEF<Manager>, IManagerRepository
    {
        public ManagerRepositoryEF(InfoInvestDbContext context) : base(context)
        {
        }
    }
}
