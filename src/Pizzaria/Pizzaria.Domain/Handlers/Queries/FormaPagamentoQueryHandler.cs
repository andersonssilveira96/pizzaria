using AutoMapper;
using MediatR;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Queries.FormaPagamento;
using Pizzaria.Domain.Response.FormaPagamento;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pizzaria.Domain.Handlers.Queries
{
    public class FormaPagamentoQueryHandler : IRequestHandler<ListarFormaPagamentoQuery, IEnumerable<FormaPagamentoResponse>>
    {
        private readonly IFormaPagamentoRepository _formaPagamentoRepository;
        private readonly IMapper _mapper;
        public FormaPagamentoQueryHandler(IFormaPagamentoRepository formaPagamentoRepository, IMapper mapper)
        {
            _formaPagamentoRepository = formaPagamentoRepository;
            _mapper = mapper;
        }
        public Task<IEnumerable<FormaPagamentoResponse>> Handle(ListarFormaPagamentoQuery query, CancellationToken cancellationToken)
        {
            var retorno = _formaPagamentoRepository.ObterTodos();
            return Task.FromResult(_mapper.Map<IEnumerable<FormaPagamentoResponse>>(retorno));
        }
    }
}
