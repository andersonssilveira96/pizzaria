using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Commands.Cliente;
using Pizzaria.Domain.Queries.Cliente;
using System.Linq;
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

        [HttpGet]
        public async Task<IActionResult> ObterTodos(int? telefone, string nome, string cpf)
        {
            var retorno = await _mediator.Send(new ListarClienteQuery() { Nome = nome, Telefone = telefone, CPF = cpf });

            if (retorno.Any())
                return OkResponse(retorno);
            else
                return NoContent();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> ObterPorId([FromRoute]int id)
        {
            var retorno = await _mediator.Send(new ObterClienteQuery() { Id = id });

            if (retorno.Sucesso.Value)
                return OkResponse(retorno);
            else
                return BadResponse("Usuario não existe");
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
