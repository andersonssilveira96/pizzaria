﻿using System;

namespace Pizzaria.Core.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataInclusao { get; set; }
        public int? UsuarioInclusaoId { get; set; }
    }
}
