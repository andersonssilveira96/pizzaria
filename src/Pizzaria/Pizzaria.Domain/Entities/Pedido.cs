using Pizzaria.Core.Domain.Entities;
using System.Collections.Generic;

namespace Pizzaria.Domain.Entities
{
    public class Pedido : EntityBase
    {
        public Pedido(decimal valorTotal, decimal desconto, decimal frete, int statusPedidoId, IEnumerable<Produto> produto, int clienteId)
        {
            ValorTotal = valorTotal;
            Desconto = desconto;
            Frete = frete;
            StatusPedidoId = statusPedidoId;
            Produto = produto;
            ClienteId = clienteId;
        }
        protected Pedido()
        {
        }      


        public decimal ValorTotal { get; private set; }
        public decimal Desconto { get; private set; }
        public decimal Frete { get; private set; }
        public int StatusPedidoId { get; private set; }
        public virtual StatusPedido StatusPedido { get; private set; }
        public virtual IEnumerable<Produto> Produto { get; private set; }
        public int ClienteId { get; private set; }
        public virtual Cliente Cliente { get; private set; }
    }    
}
