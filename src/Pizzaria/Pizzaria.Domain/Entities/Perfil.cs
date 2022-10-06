using Pizzaria.Core.Domain.Entities;
using System.Collections.Generic;

namespace Pizzaria.Domain.Entities
{
    public class Perfil : EntityBase
    {
        public Perfil(string descricao, int usuarioInclusaoId)
        {
            Descricao = descricao;           
            UsuarioInclusaoId = usuarioInclusaoId;
            Ativo = true;
        }

        protected Perfil()
        {           
        }
        public void Alterar(string descricao)
        {
            Descricao = descricao;
        }       
        public string Descricao { get; private set; }
        public virtual ICollection<PerfilPermissao> PerfilPermissao { get; private set; }
    }
}
