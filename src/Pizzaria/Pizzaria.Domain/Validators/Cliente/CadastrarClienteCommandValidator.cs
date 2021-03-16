using Pizzaria.Domain.Interfaces.Repositories;
using Pizzaria.Domain.Validators.Endereco;

namespace Pizzaria.Domain.Validators.Cliente
{
    public class CadastrarClienteCommandValidator : BaseClienteCommandValidator
    {
        public CadastrarClienteCommandValidator(IClienteRepository clienteRepository, IEnderecoRepository enderecoRepository) : base(clienteRepository)
        {
            RuleFor(cliente => cliente.Endereco).SetValidator(new CadastrarEnderecoCommandValidator(enderecoRepository));
        }
    }
}
