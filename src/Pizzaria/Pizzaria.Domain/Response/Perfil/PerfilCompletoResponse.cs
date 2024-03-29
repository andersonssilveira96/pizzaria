﻿using Pizzaria.Core.Domain.Response;
using Pizzaria.Domain.Response.Permissao;
using System.Collections.Generic;

namespace Pizzaria.Domain.Response.Perfil
{
    public class PerfilCompletoResponse : BaseResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<PermissaoResponse> Permissao { get; set; }
    }
}
