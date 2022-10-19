using SalesCome.DAC.DBContext;
using SalesCome.Infrastructure.Services.Sales.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace SalesCome.Infrastructure.Services.Sales
{
    public class SalesService : ISalesService
    {
        private readonly ISalesContext _salesContext;

        public SalesService(ISalesContext salesContext)
        {
            _salesContext = salesContext;
        }

        public async Task<List<SalesResponseModel>> GetHistorySalesAsync()
        {
            List<SalesResponseModel> salesCollection = new List<SalesResponseModel>();

            DataSet ds = await _salesContext.Fill("db_sales.sp_SalesHistoric", null);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    SalesResponseModel salesResponse = new SalesResponseModel()
                    {
                        ClientName = dr["Nombre"].ToString(),
                        DocumentNumber = dr["Documento"].ToString(),
                        ProductName = dr["NombreProducto"].ToString(),
                        Quantity = int.Parse(dr["Cantidad"].ToString()),
                        ProviderName = dr["Proveedor"].ToString(),
                        UnitPrice = decimal.Parse(dr["ValorProducto"].ToString()),
                        SaleDate = DateTime.Parse(dr["FechaCompra"].ToString())                        
                    };

                    salesCollection.Add(salesResponse);
                }
            }

            return salesCollection;
        }
    }
}
