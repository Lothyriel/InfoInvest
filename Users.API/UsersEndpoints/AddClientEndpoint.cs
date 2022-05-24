using MediatR;
using Users.Model;

namespace Users.API.UsersEndpoints
{
    public class AddClientEndpoint
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.MapPost("api/users/AddClient", AddManager);
        }

        private async Task<Guid> AddManager(IMediator mediator, AddUserVM user)
        {
            return await mediator.Send(new AddClientRequest(user));
        }
    }
}