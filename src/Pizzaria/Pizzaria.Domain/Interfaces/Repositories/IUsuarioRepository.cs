﻿using Pizzaria.Core.Domain;
using Pizzaria.Domain.Commands.Autenticacao;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario Autenticar(AutenticarCommand usuarioCommand);
    }
}
