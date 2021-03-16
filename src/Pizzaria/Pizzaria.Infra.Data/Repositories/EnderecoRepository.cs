using Microsoft.AspNetCore.Mvc;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Infra.Data.Data.Repositories.Base;

namespace Pizzaria.Infra.Data.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository([FromServices] PizzariaContext context) : base(context)
        {
        }
       
    }
}
