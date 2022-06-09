using MediatR;
using Users.Model.Manager;

namespace Users.API.Handlers
{
    public class AddManagerHandler : IRequestHandler<AddManagerRequest, Guid>
    {
        private readonly IManagerRepository _repository;

        public AddManagerHandler(IManagerRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(AddManagerRequest request, CancellationToken ct)
        {
            var id = Guid.NewGuid();
            //poderia usar um Fluent Validations para as validacoes
            var asset = new Manager(id, request.User.Name, request.User.BirthDate);

            await _repository.Add(asset);

            return id;
        }
    }
}