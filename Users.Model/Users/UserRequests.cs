using MediatR;

namespace Users.Model
{
    public record AddClientRequest(AddUserVM User) : IRequest<Guid>;
    public record AddManagerRequest(AddUserVM User) : IRequest<Guid>;
}
