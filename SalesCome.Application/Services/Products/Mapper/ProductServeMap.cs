using SalesCome.Application.Services.Products.Model;
using SalesCome.Infrastructure.Services.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesCome.Application.Services.Products.Mapper
{
    public class ProductServeMap
    {
        public ProductRequestModel MapReq(RequestProductModel model)
        {
            return new ProductRequestModel()
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

        public List<ResponseProductModel> MapListResp(List<ProductResponseModel> model)
        {
            return model.Select(s => new ResponseProductModel
            {
                TradeMark = s.TradeMark,
                ProductId = s.ProductId,
                Active = s.Active,
                CategoryProduct = s.CategoryProduct,
                ProducDescription = s.ProducDescription,
                ProductName= s.ProductName,
                QuantitieCollection = MapListRespQuantity(s.QuantitieCollection)
            }).ToList();
        }

        public List<ResponseQuantityModel> MapListRespQuantity(List<QuantityResponseModel> model)
        {
            return model.Select(s => new ResponseQuantityModel
            {
                Active = s.Active,
                ProductName = s.ProductName,
                Quantity = s.Quantity,
                ProducDescription= s.ProducDescription,
                CategoryProduct = s.CategoryProduct,
                ProductId = s.ProductId,
                TradeMark = s.TradeMark,
                UnitValue = s.UnitValue
            }).ToList();
        }

        public QuantityRequestModel MapQuantityReq(RequestQuantityModel model)
        {
            return new QuantityRequestModel()
            {
                UnitValue = model.UnitValue,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                QuantityId = model.QuantityId
            };
        }
    }
}
