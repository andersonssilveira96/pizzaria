using Pizzaria.Core.Domain.Response;
using Pizzaria.Domain.Response.Perfil;

namespace Pizzaria.Domain.Response.Usuario
{
    public class UsuarioCompletoResponse : BaseResponse
    {
        public UsuarioCompletoResponse()
        {
            
        }
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public int? Telefone { get; set; }
        public int? DDD { get; set; }
        public PerfilCompletoResponse Perfil { get; set; }
    }
}
