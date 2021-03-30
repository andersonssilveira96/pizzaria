using Pizzaria.Core.Domain.Entities;
using System.Collections.Generic;

namespace Pizzaria.Domain.Entities
{
    public class Pedido : EntityBase
    {
        public Pedido()
        {
        }      
        public decimal ValorTotal { get; private set; }
        public decimal Desconto { get; private set; }
        public decimal Frete { get; private set; }
        public int Status { get; set; }
        public virtual IEnumerable<Produto> Produto { get; private set; }
        public virtual Cliente Cliente { get; private set; }
    }    
}
