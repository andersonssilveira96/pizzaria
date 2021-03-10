using MediatR;
using Pizzaria.Domain.Response.Usuario;

namespace Pizzaria.Domain.Commands.Usuario
{
    public class CadastrarUsuarioCommand : IRequest<CadastrarUsuarioResponse>
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Senha { get; set; }
        public int PerfilId { get; set; }
        public int Telefone { get; set; }
        public int DDD { get; set; }
        public int UsuarioInclusaoId { get; set; }
        
    }
}
