using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Queries.TipoPedido;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Pedido")]
    public class TipoPedidoController : BaseController
    {
        public TipoPedidoController([FromServices] IMediator mediator)
           : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var retorno = await _mediator.Send(new ListarTipoPedidoQuery());

            if (retorno.Any())
                return Ok(retorno);
            else
                return NoContent();
        }

    }
}
