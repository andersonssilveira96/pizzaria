using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Pizzaria.Core.APIExtensions
{
    public class ApiController : ControllerBase
    {
        protected readonly IMediator _mediator;
        public ApiController()
        {
            var services = this.HttpContext.RequestServices;           
            _mediator = (IMediator)services.GetService(typeof(IMediator)); 
        }
    }
}
