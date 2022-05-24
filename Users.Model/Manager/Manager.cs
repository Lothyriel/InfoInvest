namespace Users.Model.Manager
{
    public class Manager : User
    {
        public Manager(Guid id, string name, DateTime birthDate) : base(id, name, birthDate)
        {
        }
    }
}