using Pizzaria.Core.Domain.ValueObjects;
using Pizzaria.Domain.Commands.Cliente;
using Pizzaria.Domain.Commands.Endereco;
using Pizzaria.Domain.Entities;

namespace Pizzaria.Domain.Factories.Clientes
{
    public static class ClienteFactory
    {
        public static Cliente Criar(CadastrarClienteCommand command)
        {
            return new Cliente(new CPF(command.CPF), 
                                    new Email(command.Email), 
                                    command.Nome, 
                                    command.DDD, 
                                    command.Telefone, 
                                    command.UsuarioInclusaoId,
                                    Criar(command.Endereco)
                               );
        }

        private static Endereco Criar(BaseEnderecoCommand command)
        {
            return new Endereco(command.Rua, command.Numero, command.Complemento, command.Bairro, command.Cidade, command.Estado, command.CEP);
        }
    }
}
