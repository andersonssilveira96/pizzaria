using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Commands.Autenticacao;
using Pizzaria.Domain.Commands.Usuario;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Usuarios")]
    public class UsuarioController : BaseController
    {
        public UsuarioController([FromServices]IMediator mediator) 
            : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(CadastrarUsuarioCommand command)
        {
            command.UsuarioInclusaoId = ObterUsuarioInclusaoId();

            var retorno = await _mediator.Send(command);

            if (retorno.Sucesso)
                return Ok(retorno);
            else
                return BadRequest(retorno);
        }
    }
}
