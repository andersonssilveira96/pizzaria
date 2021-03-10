using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Commands.Autenticacao;
using Pizzaria.Domain.Commands.Usuario;
using Pizzaria.Domain.Queries.Usuario;
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

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var retorno = await _mediator.Send(new ListarUsuariosQuery());

            if (retorno.Any())
                return Ok(retorno);
            else
                return NoContent();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var retorno = await _mediator.Send(new ObterUsuarioQuery() { Id = id });

            if (retorno.Sucesso)
                return Ok(retorno);
            else
                return BadRequest(retorno);
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

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Atualizar(int id, AtualizarUsuarioCommand command)
        {
            command.Id = id;

            var retorno = await _mediator.Send(command);

            if (retorno.Sucesso)
                return Ok(retorno);
            else
                return BadRequest(retorno);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Deletar(int id)
        {            
            var retorno = await _mediator.Send(new DeletarUsuarioCommand { Id = id });

            if (retorno.Sucesso)
                return Ok(retorno);
            else
                return BadRequest(retorno);
        }
    }
}
