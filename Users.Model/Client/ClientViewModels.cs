using Transactions.Model;

namespace Users.Model.Client
{
    public record ClientDetailsVM(string Name, DateTime BirthDate, List<Investment> Investments);
}
