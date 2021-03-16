using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Commands.Cliente;
using System.Threading.Tasks;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Clientes")]
    public class ClienteController : BaseController
    {
        public ClienteController([FromServices] IMediator mediator)
            : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(CadastrarClienteCommand command)
        {
            command.UsuarioInclusaoId = ObterUsuarioInclusaoId();
            command.Endereco.UsuarioInclusaoId = ObterUsuarioInclusaoId();

            var retorno = await _mediator.Send(command);

            if (retorno.Sucesso.Value)
                return Ok(retorno);
            else
                return BadResponse(retorno);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Atualizar(int id, AtualizarClienteCommand command)
        {
            command.Id = id;

            var retorno = await _mediator.Send(command);

            if (retorno.Sucesso.Value)
                return Ok(retorno);
            else
                return BadResponse(retorno);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Deletar(int id)
        {
            var retorno = await _mediator.Send(new DeletarClienteCommand { Id = id });

            if (retorno.Sucesso.Value)
                return Ok(retorno);
            else
                return BadResponse(retorno);
        }
    }
}
