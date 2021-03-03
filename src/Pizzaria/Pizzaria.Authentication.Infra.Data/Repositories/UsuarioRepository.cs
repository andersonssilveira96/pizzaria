using Microsoft.AspNetCore.Mvc;
using Pizzaria.Authentication.Domain.Entities;
using Pizzaria.Authentication.Domain.Interfaces.Repositories;
using Pizzaria.Authentication.Infra.Data.Context;
using Pizzaria.Authentication.Infra.Data.Repositories.Base;

namespace Pizzaria.Authentication.Infra.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository([FromServices] AutenticacaoContext context) 
            : base(context)
        {
        }


    }
}
