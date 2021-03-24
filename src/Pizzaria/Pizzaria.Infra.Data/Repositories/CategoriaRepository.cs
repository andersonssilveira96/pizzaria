using Microsoft.AspNetCore.Mvc;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Infra.Data.Data.Repositories.Base;
using System.Linq;

namespace Pizzaria.Infra.Data.Repositories
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository([FromServices] PizzariaContext context) : base(context)
        {
        }

        public bool VerificarCategoriaExistente(int id)
        {
            return Procurar(x => x.Id == id).Any();
        }

        public bool VerificarCategoriaExistente(int id, string descricao)
        {
            return Procurar(x => x.Descricao == descricao && x.Id != id).Any();
        }
    }
}
