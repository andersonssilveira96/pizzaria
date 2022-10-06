using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Infra.Data.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace Pizzaria.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository([FromServices] PizzariaContext context) : base(context)
        {
        }

        public override Produto ObterPorId(int id)
        {
            return DbSet.Where(x => x.Id == id).Include(x => x.Categoria).FirstOrDefault();
        }

        public override IEnumerable<Produto> ObterTodos()
        {
            return DbSet.Include(x => x.Categoria).AsNoTracking();                       
        }

        public bool VerificarProdutoComCategoria(int categoriaId)
        {
            return Procurar(x => x.CategoriaId == categoriaId).Any();
        }

        public bool VerificarProdutoExistente(int id)
        {
            return Procurar(x => x.Id == id).Any();
        }

        public bool VerificarProdutoExistente(int id, string descricao)
        {
            return Procurar(x => x.Descricao == descricao && x.Id != id).Any();
        }
    }
}
