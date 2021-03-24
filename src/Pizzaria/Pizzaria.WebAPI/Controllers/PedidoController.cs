using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "Pedido")]
    public class PedidoController : BaseController
    {
        public PedidoController([FromServices] IMediator mediator)
            : base(mediator)
        {
        }
    }
}
