using Core.Model;

namespace Users.Model
{
    public abstract class User : Entity
    {
        protected User(Guid id, string name, DateTime birthDate) : base(id)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string Name { get; }
        public DateTime BirthDate { get; }
    }
}