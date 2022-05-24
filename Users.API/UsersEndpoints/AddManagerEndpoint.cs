using Core.API;
using MediatR;
using Users.Model;

namespace Users.API.UsersEndpoints
{
    public class AddManagerEndpoint : IEndpointDefinition
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.MapPost("api/users/addManager", AddManager);
        }

        private async Task<Guid> AddManager(IMediator mediator, AddUserVM user)
        {
            return await mediator.Send(new AddManagerRequest(user));
        }
    }
}