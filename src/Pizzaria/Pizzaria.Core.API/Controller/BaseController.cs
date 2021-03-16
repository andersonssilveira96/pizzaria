using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.Domain.Response;
using System;
using System.Collections.Generic;
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

        protected IActionResult BadResponse(string mensagem)
        {
            return BadRequest(new BaseResponse() { Sucesso = false, Mensagem = new List<string>() { mensagem } });
        }

        protected IActionResult BadResponse(List<string> mensagem)
        {
            return BadRequest(new BaseResponse() { Sucesso = false, Mensagem = mensagem });
        }

        protected IActionResult BadResponse(BaseResponse response)
        {
            return BadRequest(response);
        }                   
    }
}
