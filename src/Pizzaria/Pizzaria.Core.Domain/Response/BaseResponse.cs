using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pizzaria.Core.Domain.Response
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            Mensagem = new List<string>();
            Sucesso = true;
        }

        [JsonIgnore]
        public bool Sucesso { get; set; }

        [JsonIgnore]
        public virtual List<string> Mensagem { get; set; }
    }
}
