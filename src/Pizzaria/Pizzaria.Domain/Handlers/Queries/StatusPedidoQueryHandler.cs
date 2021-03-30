using AutoMapper;
using MediatR;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.StatusPedido;
using Pizzaria.Domain.Response.StatusPedido;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class StatusPedidoQueryHandler : IRequestHandler<ListarStatusPedidoQuery, IEnumerable<StatusPedidoResponse>>
    {
        private readonly IStatusPedidoRepository _statusPedidoRepository;
        private readonly IMapper _mapper;
        public StatusPedidoQueryHandler(IStatusPedidoRepository statusPedidoRepository, IMapper mapper)
        {
            _statusPedidoRepository = statusPedidoRepository;
            _mapper = mapper;
        }
        public Task<IEnumerable<StatusPedidoResponse>> Handle(ListarStatusPedidoQuery query, CancellationToken cancellationToken)
        {
            var retorno = _statusPedidoRepository.ObterTodos();
            return Task.FromResult(_mapper.Map<IEnumerable<StatusPedidoResponse>>(retorno));
        }
    }
}
