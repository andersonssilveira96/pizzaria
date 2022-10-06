using Pizzaria.Core.Domain.Response;

namespace Pizzaria.Domain.Response.Perfil
{
    public class BasePerfilResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
