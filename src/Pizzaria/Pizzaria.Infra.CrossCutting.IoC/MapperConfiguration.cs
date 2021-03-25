using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Response.Categoria;
using Pizzaria.Domain.Response.Cliente;
using Pizzaria.Domain.Response.Endereco;
using Pizzaria.Domain.Response.Perfil;
using Pizzaria.Domain.Response.Permissao;
using Pizzaria.Domain.Response.Produto;
using Pizzaria.Domain.Response.Usuario;
using System.Linq;

namespace Pizzaria.Infra.CrossCutting.IoC
{

    public static class MapperConfiguration
    {
        public static void AddMapperConfiguration(this IServiceCollection services)
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Usuario, BaseUsuarioResponse>()
                    .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email.Valor));

                cfg.CreateMap<Usuario, UsuarioCompletoResponse>()
                 .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email.Valor));

                cfg.CreateMap<Perfil, BasePerfilResponse>();

                cfg.CreateMap<Perfil, PerfilCompletoResponse>()
                    .ForMember(res => res.Permissao, opt => 
                        opt.MapFrom(x => x.PerfilPermissao.Select(x => new PermissaoResponse() { 
                            Abreviacao = x.Permissao.Abreviacao, 
                            Descricao = x.Permissao.Descricao 
                        })));

                cfg.CreateMap<Perfil, BasePerfilResponse>();                 
                cfg.CreateMap<PerfilPermissao, PermissaoResponse>();

                cfg.CreateMap<Categoria, BaseCategoriaResponse>();
                cfg.CreateMap<Categoria, CategoriaCompletoResponse>();

                cfg.CreateMap<Produto, BaseProdutoResponse>();
                cfg.CreateMap<Produto, ProdutoCompletoResponse>();

                cfg.CreateMap<Permissao, PermissaoResponse>();

                cfg.CreateMap<Endereco, EnderecoCompletoResponse>();

                cfg.CreateMap<Cliente, BaseClienteResponse>()
                    .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email.Valor))
                    .ForMember(x => x.CPF, opt => opt.MapFrom(x => x.CPF.Valor));

                cfg.CreateMap<Cliente, ClienteCompletoResponse>()
                 .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email.Valor))
                 .ForMember(x => x.CPF, opt => opt.MapFrom(x => x.CPF.Valor));


               
                 
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
