using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;
using Pizzaria.Domain.Commands.Produto;
using Pizzaria.Domain.Queries.Produto;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Produto")]
    public class ProdutoController : BaseController
    {
        public ProdutoController([FromServices] IMediator mediator)
            : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var retorno = await _mediator.Send(new ListarProdutoQuery());

            if (retorno.Any())
                return Ok(retorno);
            else
                return NoContent();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var retorno = await _mediator.Send(new ObterProdutoQuery() { Id = id });

            if (retorno.Sucesso)
                return Ok(retorno);
            else
                return BadResponse(retorno);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar([FromForm]CadastrarProdutoCommand command)
        {
            command.UsuarioInclusaoId = ObterUsuarioInclusaoId();
           
            var retorno = await _mediator.Send(command);

            if (retorno.Sucesso)
                return OkResponse(retorno);
            else
                return BadResponse(retorno);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Atualizar(int id, AtualizarProdutoCommand command)
        {
            command.Id = id;

            var retorno = await _mediator.Send(command);

            if (retorno.Sucesso)
                return OkResponse(retorno);
            else
                return BadResponse(retorno);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Deletar(int id)
        {
            var retorno = await _mediator.Send(new DeletarProdutoCommand { Id = id });

            if (retorno.Sucesso)
                return OkResponse(retorno);
            else
                return BadResponse(retorno);
        }
    }
}
