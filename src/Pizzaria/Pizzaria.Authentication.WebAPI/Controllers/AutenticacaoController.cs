using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Authentication.Domain.Commands;
using System.Threading.Tasks;

namespace Pizzaria.Authentication.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AutenticacaoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Autenticar(AutenticarCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }
    }
}
