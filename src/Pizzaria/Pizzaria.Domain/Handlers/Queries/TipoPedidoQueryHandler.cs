using AutoMapper;
using MediatR;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.TipoPedido;
using Pizzaria.Domain.Response.TipoPedido;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class TipoPedidoQueryHandler : IRequestHandler<ListarTipoPedidoQuery, IEnumerable<TipoPedidoResponse>>
    {
        private readonly ITipoPedidoRepository _tipoPedidoRepository;
        private readonly IMapper _mapper;
        public TipoPedidoQueryHandler(ITipoPedidoRepository tipoPedidoRepository, IMapper mapper)
        {
            _tipoPedidoRepository = tipoPedidoRepository;
            _mapper = mapper;
        }
        public Task<IEnumerable<TipoPedidoResponse>> Handle(ListarTipoPedidoQuery query, CancellationToken cancellationToken)
        {
            var retorno = _tipoPedidoRepository.ObterTodos();
            return Task.FromResult(_mapper.Map<IEnumerable<TipoPedidoResponse>>(retorno));
        }
    }
}
