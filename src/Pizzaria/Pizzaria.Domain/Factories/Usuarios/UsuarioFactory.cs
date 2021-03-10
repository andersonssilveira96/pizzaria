using Pizzaria.Core.Domain.ValueObjects;
using Pizzaria.Domain.Commands.Usuario;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Factories.Usuarios
{
    public static class UsuarioFactory
    {
        public static Usuario Criar(CadastrarUsuarioCommand command)
        {
            return new Usuario(new Email(command.Email), command.Nome, command.Sobrenome, command.Senha, command.PerfilId, command.Telefone, command.DDD, command.UsuarioInclusaoId);
        }
    }
}
