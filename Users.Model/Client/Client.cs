using Transactions.Model;

namespace Users.Model.Client
{
    public class Client : User
    {
        public List<Investment> Investments { get; }

        public Client(Guid id, string name, DateTime birthDate, List<Investment> investments) : base(id, name, birthDate)
        {
            Investments = investments;
        }
    }
}