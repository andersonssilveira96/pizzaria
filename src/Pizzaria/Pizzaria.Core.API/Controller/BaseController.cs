using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.Domain.Response;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection;

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

        protected IActionResult OkResponse(BaseResponse response)
        {
            ChangeValueOkResult(response);

            return Ok(response);
        }

        protected IActionResult OkResponse(IEnumerable<BaseResponse> response)
        {             
            foreach(var item in response)
            {
                ChangeValueOkResult(item);
            }

            return Ok(response);
        }

        private void ChangeValueOkResult(object p)
        {
            Type t = p.GetType();
            t.GetProperties()
                .Where(c => c.PropertyType.IsClass || c.Name == "Sucesso" || c.Name == "Mensagem")
                .ToList()
                .ForEach(c =>
                {
                    object child = c.GetValue(p);

                    if (c.PropertyType == typeof(bool?) || c.PropertyType == typeof(List<string>))
                    {
                        if (string.Equals(c.Name, "Sucesso"))                          
                                c.SetValue(p, null);

                        if (string.Equals(c.Name, "Mensagem"))                          
                                c.SetValue(p, null);
                    }
                    else
                    {
                        if (child != null)
                            ChangeValueOkResult(c.GetValue(p));
                    }
                });
        }
    }
}
