using SalesCome.Infrastructure.Services.Products.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesCome.Infrastructure.Services.Products
{
    public interface IProductService
    {
        Task<bool> SaveProductAsync(ProductRequestModel client);

        Task<bool> UpdateProductAsync(ProductRequestModel client);

        Task<bool> DeleteProductAsync(ProductRequestModel client);

        Task<List<ProductResponseModel>> GetProductsAsync();

        Task<bool> SaveQuantityAsync(QuantityRequestModel contact);

        Task<bool> UpdateQuantityAsync(QuantityRequestModel contact);

        Task<bool> DeleteQuantityAsync(QuantityRequestModel contact);

        Task<List<QuantityResponseModel>> QuantityCollectionAsync(long ClientId);
    }
}
