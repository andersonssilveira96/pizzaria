using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Authentication.Domain.Commands;
using Pizzaria.Core.APIExtensions;
using System.Threading.Tasks;

namespace Pizzaria.Authentication.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ApiController
    {    

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Autenticar(AutenticarCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }
    }
}
