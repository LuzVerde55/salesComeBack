
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesCome.DAC.DBContext;
using SalesCome.Infrastructure.Services.Autentica;
using SalesCome.Infrastructure.Services.Cache;
using SalesCome.Infrastructure.Services.Clients;
using SalesCome.Infrastructure.Services.Products;
using SalesCome.Infrastructure.Services.Sales;
using SalesCome.Infrastructure.Services.Users;

namespace SalesCome.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ISalesContext, SalesContext>(db => new SalesContext(configuration, "SalesConnectionString"));
            services.AddSingleton<IAutentica, Autentica>();
            services.AddSingleton<ICacheService, CacheService>();
            services.AddSingleton<IClientService, ClientService>();
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<ISalesService, SalesService>();
        }
    }
}
