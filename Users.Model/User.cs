using Core.Model;

namespace Users.Model
{
    public abstract class User : Entity
    {
        protected User(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; }
        public DateTime BirthDate { get; }
    }
}