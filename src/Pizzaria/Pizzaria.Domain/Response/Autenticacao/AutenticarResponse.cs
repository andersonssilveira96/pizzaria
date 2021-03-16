using Pizzaria.Core.Domain.Response;
using Pizzaria.Domain.Response.Perfil;

namespace Pizzaria.Domain.Response.Autenticacao
{
    public class AutenticarResponse : BaseResponse
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public PerfilCompletoResponse Perfil { get; set; }
    }
}
