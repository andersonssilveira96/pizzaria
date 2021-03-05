using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Pizzaria.Core.API
{
    public class ApiController : ControllerBase
    {
        protected readonly IMediator _mediator;
        public ApiController(IMediator mediator)
        {
            _mediator = mediator;                    
        }
    }
}
