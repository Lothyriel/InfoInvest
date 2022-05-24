using Assets.Infra;
using Users.Model;

namespace Users.Infra
{
    public class UserRepositoryEF : RepositoryEF<User>, IUserRepository
    {
        public UserRepositoryEF(UsersDbContext context) : base(context)
        {
        }
    }
}