using MediatR;

namespace Users.Model.Managers
{
    public record AddManagerRequest(UserVM User) : IRequest<Guid>;
    public record GetManagerRequest(Guid Id) : IRequest<UserVM>;
}
