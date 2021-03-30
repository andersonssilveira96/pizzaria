using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Queries.FormaPagamento;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Pedido")]
    public class FormaPagamentoController : BaseController
    {
        public FormaPagamentoController([FromServices] IMediator mediator)
          : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var retorno = await _mediator.Send(new ListarFormaPagamentoQuery());

            if (retorno.Any())
                return Ok(retorno);
            else
                return NoContent();
        }
    }
}
