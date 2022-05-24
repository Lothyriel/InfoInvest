namespace Users.Model
{
    public record GetUserVM(Guid Id);
    public record UserVM(string Name, DateTime BirthDate);
}