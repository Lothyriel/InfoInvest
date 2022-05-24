using MediatR;

namespace Users.Model.Client
{
    public record GetClientRequest(Guid Id) : IRequest<ClientDetailsVM>;
    public record AddClientRequest(UserVM User) : IRequest<Guid>;
}
