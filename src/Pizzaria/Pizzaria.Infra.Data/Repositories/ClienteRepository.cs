using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Infra.Data.Data.Repositories.Base;
using System.Linq;

namespace Pizzaria.Infra.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository([FromServices] PizzariaContext context) : base(context)
        {
        }

        public bool VerificarEmailExistente(int id, string email)
        {
            return Procurar(x => x.Email.Valor == email && x.Id != id).Any();
        }

        public bool VerificarClienteExistente(int id)
        {
            return Procurar(x => x.Id == id).Any();
        }
        public override Cliente ObterPorId(int id)
        {
            return DbSet.Where(x => x.Id == id).Include(x => x.Endereco).SingleOrDefault();
        }
    }
}
