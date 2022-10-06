using Pizzaria.Domain.Commands.Perfil;
using Pizzaria.Domain.Entities;
using System.Collections.Generic;

namespace Pizzaria.Domain.Factories.Perfis
{
    public static class PerfilFactory
    {
        public static Perfil Criar(CadastrarPerfilCommand command)
        {
            return new Perfil(command.Descricao, command.UsuarioInclusaoId);
        }
     
    }
}
