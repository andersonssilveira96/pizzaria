using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Commands.Perfil;
using Pizzaria.Domain.Queries.Perfil;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Administracao")]
    public class PerfilController : BaseController
    {
        public PerfilController([FromServices] IMediator mediator)
            : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var retorno = await _mediator.Send(new ListarPerfilQuery());

            if (retorno.Any())
                return Ok(retorno);
            else
                return NoContent();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var retorno = await _mediator.Send(new ObterPerfilQuery() { Id = id });

            if (!retorno.Sucesso.HasValue)
                return Ok(retorno);
            else
                return BadResponse("Perfil não existe");
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(CadastrarPerfilCommand command)
        {
            command.UsuarioInclusaoId = ObterUsuarioInclusaoId();

            var retorno = await _mediator.Send(command);

            if (!retorno.Sucesso.HasValue)
                return Ok(retorno);
            else
                return BadResponse(retorno);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Atualizar(int id, AtualizarPerfilCommand command)
        {
            command.Id = id;

            var retorno = await _mediator.Send(command);

            if (!retorno.Sucesso.HasValue)
                return Ok(retorno);
            else
                return BadResponse(retorno);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Deletar(int id)
        {
            var retorno = await _mediator.Send(new DeletarPerfilCommand { Id = id });

            if (!retorno.Sucesso.HasValue)
                return Ok(retorno);
            else
                return BadResponse(retorno);
        }
    }
}
