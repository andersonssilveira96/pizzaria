using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Commands.Autenticacao;
using System.Threading.Tasks;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "USR")]
    public class UsuarioController : BaseController
    {
        public UsuarioController([FromServices]IMediator mediator) 
            : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(AutenticarCommand command)
        {
            var retorno = await _mediator.Send(command);

            if (retorno.Sucesso)
                return Ok(retorno);
            else
                return BadRequest(retorno);
        }
    }
}
