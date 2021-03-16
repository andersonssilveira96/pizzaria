using Pizzaria.Domain.Interfaces.Repositories;

namespace Pizzaria.Domain.Validators.Endereco
{
    public class CadastrarEnderecoCommandValidator : BaseEnderecoCommandValidator
    {
        public CadastrarEnderecoCommandValidator(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
        }
    }
}
