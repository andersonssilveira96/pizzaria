namespace Pizzaria.Authentication.Domain.ValueObjects
{
    public struct Email
    {
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
    }
}
