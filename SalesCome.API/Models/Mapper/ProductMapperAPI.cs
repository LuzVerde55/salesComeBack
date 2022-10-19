using SalesCome.API.Models.Products;
using SalesCome.Application.Services.Products.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalesCome.API.Models.Mapper
{
    public class ProductMapperAPI
    {
        public RequestProductModel MapReq(RequestProductModelAPI model)
        {
            return new RequestProductModel()
            {
                Active = model.Active,
                ProducDescription = model.ProducDescription,
                ProductCategory = model.ProductCategory,
                ProductName = model.ProductName,
                ProductId = model.ProductId,
                ProviderId = model.ProviderId,
                TradeMark = model.TradeMark,
                UserCreate = model.UserCreate
            };
        }

        public List<ResponseProductModelAPI> MapListResp(List<ResponseProductModel> model)
        {
            return model.Select(s => new ResponseProductModelAPI
            {
                TradeMark = s.TradeMark,
                ProductId = s.ProductId,
                Active = s.Active,
                CategoryProduct = s.CategoryProduct,
                ProducDescription = s.ProducDescription,
                ProductName = s.ProductName,
                QuantitieCollection = MapListRespQuantity(s.QuantitieCollection)
            }).ToList();
        }

        public List<ResponseQuantityModelAPI> MapListRespQuantity(List<ResponseQuantityModel> model)
        {
            return model.Select(s => new ResponseQuantityModelAPI
            {
                Active = s.Active,
                ProductName = s.ProductName,
                Quantity = s.Quantity,
                ProducDescription = s.ProducDescription,
                CategoryProduct = s.CategoryProduct,
                ProductId = s.ProductId,
                TradeMark = s.TradeMark,
                UnitValue = s.UnitValue
            }).ToList();
        }

        public RequestQuantityModel MapQuantityReq(RequestQuantityModelAPI model)
        {
            return new RequestQuantityModel()
            {
                UnitValue = model.UnitValue,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                QuantityId = model.QuantityId
            };
        }
    }
}
