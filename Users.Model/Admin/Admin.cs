namespace Users.Model.Admin
{
    public class Admin : User
    {
        public Admin(Guid id, string name, DateTime birthDate) : base(id, name, birthDate)
        {
        }
    }
}