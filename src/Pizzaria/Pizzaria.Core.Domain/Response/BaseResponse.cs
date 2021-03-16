using System.Collections.Generic;

namespace Pizzaria.Core.Domain.Response
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Mensagem = null;
            Sucesso = null;
        }
        public bool? Sucesso { get; set; }
        public virtual List<string> Mensagem { get; set; }
    }
}
