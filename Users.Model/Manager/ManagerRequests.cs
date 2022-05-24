using MediatR;

namespace Users.Model.Manager
{
    public record AddManagerRequest(UserVM User) : IRequest<Guid>;
    public record GetManagerRequest(Guid Id) : IRequest<UserVM>;
}
