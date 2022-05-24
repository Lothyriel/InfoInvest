using Assets.Model;
using Assets.Model.Requests;
using MediatR;

namespace Assets.API.Handlers
{
    public class AddAssetHandler : IRequestHandler<AddAssetRequest, Guid>
    {
        private readonly IAssetRepository _repository;

        public AddAssetHandler(IAssetRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(AddAssetRequest request, CancellationToken ct)
        {
            var id = Guid.NewGuid();
                                                                                //poderia usar um Fluent Validations para as validacoes
            var asset = new Asset(id, request.Asset.Name, request.Asset.Group); //poderia usar um Automapper para mapear de VM/entidade

            await Task.Run(() => _repository.Add(asset), ct);

            return id;
        }
    }
}
