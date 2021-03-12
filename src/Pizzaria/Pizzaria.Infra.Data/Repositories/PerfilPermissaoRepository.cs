using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Infra.Data.Data.Repositories.Base;
using System.Linq;

namespace Pizzaria.Infra.Data.Repositories
{
    public class PerfilPermissaoRepository : Repository<PerfilPermissao>, IPerfilPermissaoRepository
    {
        public PerfilPermissaoRepository([FromServices] PizzariaContext context) 
            : base(context)
        {
        }

        public void DeletarPorPerfilId(int PerfilId)
        {
            var registros = DbSet.Where(x => x.PerfilId == PerfilId).AsNoTracking();
            foreach(var item in registros)
            {
                Remover(item.Id);
            }
        }
    }
}
