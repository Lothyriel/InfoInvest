using MediatR;
using Users.Model;

namespace Users.API.Handlers
{
    public class AddManagerHandler : IRequestHandler<AddManagerRequest, Guid>
    {
        private readonly IUserRepository _repository;

        public AddManagerHandler(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(AddManagerRequest request, CancellationToken ct)
        {
            var id = Guid.NewGuid();
                                                                                    //poderia usar um Fluent Validations para as validacoes
            var asset = new Manager(id, request.User.Name, request.User.BirthDate);

            await Task.Run(() => _repository.Add(asset), ct);

            return id;
        }
    }
}