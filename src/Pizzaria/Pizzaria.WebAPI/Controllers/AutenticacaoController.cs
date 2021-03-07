using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Domain.Commands;
using Pizzaria.Core.API.Controller;
using System.Threading.Tasks;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : BaseController
    {      
        public AutenticacaoController([FromServices]IMediator mediator)
            : base(mediator)
        {
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Autenticar(AutenticarCommand command)
        {
            var retorno = await _mediator.Send(command);

            if (retorno.Sucesso)
                return Ok(retorno);
            else
                return BadRequest(new { Sucesso = retorno.Sucesso, Mensagem = retorno.Mesagem });
        }       
    }
}
