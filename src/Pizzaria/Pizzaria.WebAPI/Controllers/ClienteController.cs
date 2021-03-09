using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.API.Controller;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "CLS")]
    public class ClienteController : BaseController
    {
        public ClienteController([FromServices] IMediator mediator)
            : base(mediator)
        {
        }
    }
}
