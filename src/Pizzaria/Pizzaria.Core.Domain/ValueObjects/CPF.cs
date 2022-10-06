using System.Collections.Generic;

namespace Pizzaria.Core.Domain.ValueObjects
{
    public class CPF : ValueObject
    {
        public CPF()
        {
        }

        public CPF(string cpf)
        {
            Valor = cpf;
        }
        public string Valor { get; private set; }
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Valor;
        }
    }
}
