using Microsoft.AspNetCore.Mvc;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Infra.Data.Data.Repositories.Base;
using System.Linq;

namespace Pizzaria.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository([FromServices] PizzariaContext context) : base(context)
        {
        }

        public bool VerificarProdutoComCategoria(int categoriaId)
        {
            return Procurar(x => x.CategoriaId == categoriaId).Any();
        }
    }
}
