using Microsoft.Extensions.DependencyInjection;
using MinhaApiCore.Business.Intefaces;
using MinhaApiCore.Data.Context;
using MinhaApiCore.Data.Repository;

namespace MinhaApiCore.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDepencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();

            return services;
        }
    }
}
