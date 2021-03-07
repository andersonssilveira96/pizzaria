using System.Collections.Generic;

namespace Pizzaria.Core.Domain.Response
{
    public class BaseResponse
    {
        public bool Sucesso { get; set; }
        public List<string> Mesagem { get; set; }
    }
}
