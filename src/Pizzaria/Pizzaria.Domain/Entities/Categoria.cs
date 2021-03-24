using Pizzaria.Core.Domain.Entities;
using System.Collections.Generic;

namespace Pizzaria.Domain.Entities
{
    public class Categoria : EntityBase
    {
        protected Categoria()
        {
        }

        public Categoria(string descricao, int usuarioInclusaoId)
        {
            Descricao = descricao;
            UsuarioInclusaoId = usuarioInclusaoId;
        }

        public void Alterar(string descricao)
        {
            Descricao = descricao;
        }
        public string Descricao { get; private set; }
        public virtual ICollection<Produto> Produto { get; private set; }
        public virtual Usuario UsuarioInclusao { get; private set; }
    }
}
