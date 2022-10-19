
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesCome.Application.Services.Clients;
using SalesCome.Application.Services.Products;
using SalesCome.Application.Services.Sales;
using SalesCome.Application.Services.Security;
using System.Reflection;

namespace SalesCome.Application
{
    public static class DependencyInjection
    {
        public static void AddAplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddSingleton<ISecurityService, SecurityService>();
            services.AddSingleton<IClientServices, ClientServices>();
            services.AddSingleton<ISalesServices, SalesServices>();
            services.AddSingleton<IProductServices, ProductServices>();
        }
    }
}
