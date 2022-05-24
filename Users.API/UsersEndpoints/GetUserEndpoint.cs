using Core.API;
using MediatR;
using Users.Model;

namespace Users.API.UsersEndpoints
{
    public class GetUserEndpoint : IEndpointDefinition
    {
        public void DefineEndpoints(WebApplication app)
        {
            app.MapGet("api/users/getUser", GetUser);
        }

        private async Task<User> GetUser(IMediator mediator)
        {
            throw new NotImplementedException();
        }
    }
}
