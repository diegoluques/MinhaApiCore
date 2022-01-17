using Microsoft.Extensions.DependencyInjection;
using MinhaApiCore.Business.Intefaces;
using MinhaApiCore.Business.Notificacoes;
using MinhaApiCore.Business.Services;
using MinhaApiCore.Data.Context;
using MinhaApiCore.Data.Repository;

namespace MinhaApiCore.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDepencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;
        }
    }
}
