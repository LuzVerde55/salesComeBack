using SalesCome.Application.Services.Products.Mapper;
using SalesCome.Application.Services.Products.Model;
using SalesCome.Infrastructure.Services.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesCome.Application.Services.Products
{
    public class ProductServices : IProductServices
    {
        private readonly IProductService _productService;

        public ProductServices(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<bool> SaveProductAsync(RequestProductModel model)
        {
            return await _productService.SaveProductAsync(new ProductServeMap().MapReq(model));
        }

        public async Task<bool> UpdateProductAsync(RequestProductModel model)
        {
            return await _productService.UpdateProductAsync(new ProductServeMap().MapReq(model));
        }

        public async Task<bool> DelteProductAsync(RequestProductModel model)
        {
            return await _productService.DeleteProductAsync(new ProductServeMap().MapReq(model));
        }

        public async Task<List<ResponseProductModel>> GetProductAsync()
        {
            return new ProductServeMap().MapListResp(await _productService.GetProductsAsync());
        }

        public async Task<bool> SaveQuantityAsync(RequestQuantityModel model)
        {
            return await _productService.SaveQuantityAsync(new ProductServeMap().MapQuantityReq(model));
        }

        public async Task<bool> UpdateQuantityAsync(RequestQuantityModel model)
        {
            return await _productService.UpdateQuantityAsync(new ProductServeMap().MapQuantityReq(model));
        }

        public async Task<bool> DeleteQuantityAsync(RequestQuantityModel model)
        {
            return await _productService.DeleteQuantityAsync(new ProductServeMap().MapQuantityReq(model));
        }

        public async Task<List<ResponseQuantityModel>> GetQuantityAsync(long productId)
        {
            return new ProductServeMap().MapListRespQuantity(await _productService.QuantityCollectionAsync(productId));
        }
    }
}
