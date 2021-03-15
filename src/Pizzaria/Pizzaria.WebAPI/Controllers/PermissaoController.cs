using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Queries.Permissao;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Administracao")]
    public class PermissaoController : BaseController
    {
        public PermissaoController([FromServices] IMediator mediator)
           : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var retorno = await _mediator.Send(new ListarPermissaoQuery());

            if (retorno.Any())
                return OkResponse(retorno);
            else
                return NoContent();
        }
    }
}
