namespace Users.Model
{
    public class Client : User
    {
        public List<Investment> Investments { get; }

        public Client(Guid id, string name, DateTime birthDate) : base(id, name, birthDate)
        {
        }
    }
}