using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pizzaria.Core.Domain.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Pizzaria.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CEPController : ControllerBase
    {
        [HttpGet]
        [Route("{cep}")]
        [AllowAnonymous]
        public IActionResult ObterPorCEP(string cep)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cep + "/json/");
            request.AllowAutoRedirect = false;
            try
            {
                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    return BadRequest(new BaseResponse() { Sucesso = false, Mensagem = new List<string>() { "CEP não encontrado" } });
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            return Ok(response);
                        }
                    }

                    return BadRequest(new BaseResponse() { Sucesso = false, Mensagem = new List<string>() { "CEP não encontrado" } });
                }
            }
            catch
            {
                return BadRequest(new BaseResponse() { Sucesso = false, Mensagem = new List<string>() { "CEP não encontrado" } });
            }
            
        }
    }
}
