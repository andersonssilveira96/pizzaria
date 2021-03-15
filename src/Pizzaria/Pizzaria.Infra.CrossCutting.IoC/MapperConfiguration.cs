using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Pizzaria.Domain.Entities;
using Pizzaria.Domain.Response.Perfil;
using Pizzaria.Domain.Response.Permissao;
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
                cfg.CreateMap<Permissao, PermissaoResponse>();
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
