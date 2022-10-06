using Pizzaria.Core.Domain.Entities;

namespace Pizzaria.Domain.Entities
{
    public class Produto : EntityBase
    {
        public Produto(decimal valor, string descricao, int categoriaId, int usuarioInclusaoId)
        {
            Valor = valor;
            Descricao = descricao;
            CategoriaId = categoriaId;           
            UsuarioInclusaoId = usuarioInclusaoId;
        }
        protected Produto() 
        { 
        }
        
        public void Alterar(decimal valor, string descricao, int categoriaId)
        {
            Valor = valor;
            Descricao = descricao;
            CategoriaId = categoriaId;
        }
        public decimal Valor { get; private set; }
        public string Descricao { get; private set; }        
        public int CategoriaId { get; private set; }
        public virtual Categoria Categoria { get; private set; }
        public virtual Usuario UsuarioInclusao { get; private set; }
    }
}
