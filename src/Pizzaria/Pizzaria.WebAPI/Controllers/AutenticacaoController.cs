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
    [AllowAnonymous]
    public class AutenticacaoController : BaseController
    {      
        public AutenticacaoController([FromServices]IMediator mediator)
            : base(mediator)
        {
        }

        [HttpPost]       
        public async Task<IActionResult> Autenticar(AutenticarCommand command)
        {
            var retorno = await _mediator.Send(command);

            if (retorno.Sucesso.HasValue)
                return OkResponse(retorno);
            else
                return BadResponse(retorno);
        }       
    }
}
