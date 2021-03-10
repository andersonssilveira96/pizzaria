using Microsoft.AspNetCore.Mvc;
using Pizzaria.Domain.Commands.Autenticacao;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Infra.Data.Data.Context;
using Pizzaria.Infra.Data.Data.Repositories.Base;
using System.Linq;

namespace Pizzaria.Infra.Data.Data.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
    
        public UsuarioRepository([FromServices] AutenticacaoContext context) 
            : base(context)
        {
        }

        public Usuario Autenticar(AutenticarCommand usuarioCommand)
        {            
            return Procurar(x => x.Email.Valor == usuarioCommand.Email && x.Senha == usuarioCommand.Senha).FirstOrDefault();                      
        }

        public bool VerificarEmailExistente(string email)
        {
            return Procurar(x => x.Email.Valor == email).Any();
        }
    }
}
