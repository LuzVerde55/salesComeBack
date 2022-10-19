using SalesCome.Application.Services.Products.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesCome.Application.Services.Products
{
    public interface IProductServices
    {
        Task<bool> SaveProductAsync(RequestProductModel model);

        Task<bool> UpdateProductAsync(RequestProductModel model);

        Task<bool> DelteProductAsync(RequestProductModel model);

        Task<List<ResponseProductModel>> GetProductAsync();

        Task<bool> SaveQuantityAsync(RequestQuantityModel model);

        Task<bool> UpdateQuantityAsync(RequestQuantityModel model);

        Task<bool> DeleteQuantityAsync(RequestQuantityModel model);

        Task<List<ResponseQuantityModel>> GetQuantityAsync(long productId);
    }
}
