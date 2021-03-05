using Microsoft.AspNetCore.Mvc;
using Pizzaria.Authentication.Domain.Commands;
using Pizzaria.Authentication.Domain.Entities;
using Pizzaria.Authentication.Domain.Interfaces.Repositories;
using Pizzaria.Authentication.Domain.Response;
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

        public AutenticarResponse Autenticar(AutenticarCommand usuarioCommand)
        {            
            var model = Procurar(x => x.Email.Valor == usuarioCommand.Email && x.Senha == usuarioCommand.Senha);
            
            if(model != null)
            {

            }

            return new AutenticarResponse();
        }       
    }
}
