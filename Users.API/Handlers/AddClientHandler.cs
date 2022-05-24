using MediatR;
using Users.Model;

namespace Users.API.Handlers
{
    public class AddClientHandler : IRequestHandler<AddClientRequest, Guid>
    {
        private readonly IUserRepository _repository;

        public AddClientHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(AddClientRequest request, CancellationToken ct)
        {
            var id = Guid.NewGuid();
                                                                                 //poderia usar um Fluent Validations para as validacoes
            var asset = new Client(id, request.User.Name, request.User.BirthDate);

            await Task.Run(() => _repository.Add(asset), ct);

            return id;
        }
    }
}
