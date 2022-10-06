using Pizzaria.Core.Domain.Entities;

namespace Pizzaria.Domain.Entities
{
    public class StatusPedido : EntityBase
    {
        public StatusPedido()
        {

        }
        public string Descricao { get; private set; }
    }
    
}
