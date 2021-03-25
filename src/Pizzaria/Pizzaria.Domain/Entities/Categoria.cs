using Pizzaria.Core.Domain.Entities;
using System.Collections.Generic;

namespace Pizzaria.Domain.Entities
{
    public class Categoria : EntityBase
    {
        protected Categoria()
        {
        }

        public Categoria(string descricao, string icone, int usuarioInclusaoId)
        {
            Descricao = descricao;
            Icone = icone;
            UsuarioInclusaoId = usuarioInclusaoId;            
        }

        public void Alterar(string descricao, string icone)
        {
            Descricao = descricao;
            Icone = icone;
        }
        public string Descricao { get; private set; }
        public string Icone { get; private set; }
        public virtual ICollection<Produto> Produto { get; private set; }
        public virtual Usuario UsuarioInclusao { get; private set; }
    }
}

