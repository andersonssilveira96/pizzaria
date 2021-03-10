﻿using Pizzaria.Core.Domain.Response;
using Pizzaria.Domain.Response.Perfil;

namespace Pizzaria.Domain.Response.Usuario
{
    public class BaseUsuarioResponse : BaseResponse
    {
        public BaseUsuarioResponse()
        {
            Sucesso = true;
        }
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public int? Telefone { get; set; }
        public int? DDD { get; set; }
        public PerfilResponse Perfil { get; set; }
    }
}