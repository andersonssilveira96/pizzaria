using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Cliente
{
    public class AtualizarClienteCommandValidator : BaseClienteCommandValidator
    {
        public AtualizarClienteCommandValidator(IClienteRepository clienteRepository, IEnderecoRepository enderecoRepository) : base(clienteRepository, enderecoRepository)
        {
        }
    }
}
