﻿using MediatR;
using Users.Model.Client;

namespace Users.API.Handlers
{
    public class AddClientHandler : IRequestHandler<AddClientRequest, Guid>
    {
        private readonly IClientRepository _repository;

        public AddClientHandler(IClientRepository repository)
        {
            _repository = repository;
        }
        public async Task<Guid> Handle(AddClientRequest request, CancellationToken ct)
        {
            var id = Guid.NewGuid();
            //poderia usar um Fluent Validations para as validacoes
            var asset = new Client(id, request.User.Name, request.User.BirthDate, new());

            await _repository.Add(asset);

            return id;
        }
    }
}