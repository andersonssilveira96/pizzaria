using Pizzaria.Core.Domain.Response;

namespace Pizzaria.Domain.Response.Permissao
{
    public class PermissaoResponse : BaseResponse
    {
        public string Descricao { get; set; }
        public string Abreviacao { get; set; }
    }
}
