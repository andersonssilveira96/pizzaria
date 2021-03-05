using System.Collections.Generic;

namespace Pizzaria.Core.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        protected Email()
        {
        }
        public Email(string email)
        {
            Valor = email;
            Valido = false;
            Validar();
        }
        public string Valor { get; private set; }
        public bool Valido { get; private set; } 
        public void Validar()
        {
            if (Valor != null) Valido = true;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Valor;
        }
    }
}
