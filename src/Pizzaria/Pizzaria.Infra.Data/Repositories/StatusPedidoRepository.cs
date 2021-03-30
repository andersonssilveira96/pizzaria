using Microsoft.AspNetCore.Mvc;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Infra.Data.Data.Repositories.Base;

namespace Pizzaria.Infra.Data.Repositories
{
    public class StatusPedidoRepository : Repository<StatusPedido>, IStatusPedidoRepository
    {
        public StatusPedidoRepository([FromServices] PizzariaContext context) : base(context)
        {
        }
    }
    
}
