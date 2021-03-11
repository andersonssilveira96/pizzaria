using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Infra.Data.Data.Repositories.Base;
using System.Linq;

namespace Pizzaria.Infra.Data.Repositories
{
    public class PerfilRepository : Repository<Perfil>, IPerfilRepository
    {
        public PerfilRepository([FromServices] AutenticacaoContext context) : base(context)
        {
        }

        public override Perfil ObterPorId(int id)
        {
            return DbSet.Where(x => x.Id == id)
                        .Include(x => x.PerfilPermissao)
                        .FirstOrDefault();
        }
    }
}
