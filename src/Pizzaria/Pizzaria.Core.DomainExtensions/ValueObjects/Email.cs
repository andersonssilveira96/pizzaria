﻿using System.Collections.Generic;

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
        }
        public string Valor { get; private set; }
       
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Valor;
        }
    }
}
