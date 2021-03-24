﻿using Pizzaria.Core.Domain.Entities;

namespace Pizzaria.Domain.Entities
{
    public class Produto : EntityBase
    {
        protected Produto() 
        { 
        }
        public decimal Valor { get; private set; }
        public string Descricao { get; private set; }        
        public int CategoriaId { get; private set; }
        public byte[] Imagem { get; private set; }
        public virtual Categoria Categoria { get; private set; }
        public virtual Usuario UsuarioInclusao { get; private set; }
    }
}