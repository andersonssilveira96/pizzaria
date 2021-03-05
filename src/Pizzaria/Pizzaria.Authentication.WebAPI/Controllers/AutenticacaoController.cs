using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Authentication.Domain.Commands;
using Pizzaria.Core.API;
using System.Threading.Tasks;

namespace Pizzaria.Authentication.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ApiController
    {      
        public AutenticacaoController([FromServices]IMediator mediator)
            : base(mediator)
        {
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Autenticar(AutenticarCommand command)
        {     
            return Ok(await _mediator.Send(command));
        }
    }
}
