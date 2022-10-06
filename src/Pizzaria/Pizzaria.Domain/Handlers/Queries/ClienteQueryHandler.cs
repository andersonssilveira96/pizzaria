using AutoMapper;
using MediatR;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.Cliente;
using Pizzaria.Domain.Response.Cliente;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class ClienteQueryHandler :
             IRequestHandler<ListarClienteQuery, IEnumerable<BaseClienteResponse>>,
             IRequestHandler<ObterClienteQuery, ClienteCompletoResponse>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        public ClienteQueryHandler(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
        public Task<ClienteCompletoResponse> Handle(ObterClienteQuery query, CancellationToken cancellationToken)
        {
            var retorno = _clienteRepository.ObterPorId(query.Id);

            if (retorno != null)
                return Task.FromResult(_mapper.Map<ClienteCompletoResponse>(retorno));
            else
                return Task.FromResult(new ClienteCompletoResponse() { Sucesso = false, Mensagem = new List<string>() { "Cliente não encontrado" } });            
        }

        public Task<IEnumerable<BaseClienteResponse>> Handle(ListarClienteQuery query, CancellationToken cancellationToken)
        {
            var retorno = _clienteRepository.ObterTodos(query);
            return Task.FromResult(_mapper.Map<IEnumerable<BaseClienteResponse>>(retorno));
        }
    }
}
