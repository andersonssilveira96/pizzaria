using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace Pizzaria.Core.API.Controller
{
    public class BaseController : ControllerBase
    {
        protected readonly IMediator _mediator;
        public BaseController(IMediator mediator)
        {
            _mediator = mediator;                    
        }

        protected int ObterUsuarioInclusaoId()
        {
            var jwt = Request.Headers["Authorization"].FirstOrDefault().Replace("Bearer ", string.Empty);
            var token = new JwtSecurityTokenHandler().ReadJwtToken(jwt);
            return Convert.ToInt32(token.Claims.First(c => c.Type == "Id").Value);
        }
    }
}
