using SalesCome.Application.Services.Sales.Model;
using SalesCome.Infrastructure.Services.Sales.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalesCome.Application.Services.Sales.Mapper
{
    public class SalesServiceMap
    {
        public List<ResponseSalesModel> MapList(List<SalesResponseModel> model)
        {
            return model.Select(s => new ResponseSalesModel
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
