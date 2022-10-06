using Pizzaria.Core.Domain.Entities;

namespace Pizzaria.Domain.Entities
{
    public class FormaPagamento  : EntityBase
    {
        public FormaPagamento()
        {
        }
        public string Descricao { get; private set; }
    }
}
