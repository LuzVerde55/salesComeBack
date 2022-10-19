using SalesCome.API.Models.Sales;
using SalesCome.Application.Services.Sales.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalesCome.API.Models.Mapper
{
    public class SalesMapperAPI
    {
        public List<ResponseSalesModelAPI> MapListResp(List<ResponseSalesModel> model)
        {
            return model.Select(s => new ResponseSalesModelAPI
            {
                ClientName = s.ClientName,
                DocumentNumber = s.DocumentNumber,
                ProductName = s.ProductName,
                ProviderName = s.ProviderName,
                Quantity = s.Quantity,
                SaleDate = s.SaleDate,
                UnitPrice = s.UnitPrice
            }).ToList();
        }
    }
}
