using Transactions.Model;

namespace Users.Model.Client
{
    public class Client : User
    {
        public List<Investment> Investments { get; }

        public Client(string name, DateTime birthDate, List<Investment> investments) : base(name, birthDate)
        {
            Investments = investments;
        }
    }
}