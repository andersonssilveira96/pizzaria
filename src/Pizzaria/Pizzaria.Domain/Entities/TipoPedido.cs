using Pizzaria.Core.Domain.Entities;

namespace Pizzaria.Domain.Entities
{
    public class TipoPedido : EntityBase
    {
        public TipoPedido()
        {

        }
        public string Descricao { get; private set; }
    }
}
