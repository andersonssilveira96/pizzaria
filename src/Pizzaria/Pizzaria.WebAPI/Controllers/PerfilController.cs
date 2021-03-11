using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Queries.Perfil;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Administracao")]
    public class PerfilController : BaseController
    {
        public PerfilController([FromServices] IMediator mediator)
            : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var retorno = await _mediator.Send(new ListarPerfilQuery());

            if (retorno.Any())
                return Ok(retorno);
            else
                return NoContent();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var retorno = await _mediator.Send(new ObterPerfilQuery() { Id = id });

            if (retorno.Sucesso)
                return Ok(retorno);
            else
                return BadReponse("Perfil não existe");
        }

    }
}
