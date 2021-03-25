using Pizzaria.Domain.Commands.Categoria;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Factories.Categorias
{
    public static class CategoriaFactory
    {
        public static Categoria Criar(CadastrarCategoriaCommand command)
        {
            return new Categoria(command.Descricao, command.Icone, command.UsuarioInclusaoId);
        }
    }
}
