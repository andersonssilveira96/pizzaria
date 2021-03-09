using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "PTS")]
    public class ProdutoController : BaseController
    {
        public ProdutoController([FromServices] IMediator mediator)
            : base(mediator)
        {
        }
    }
}
