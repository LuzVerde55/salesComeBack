using SalesCome.Application.Services.Sales.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesCome.Application.Services.Sales
{
    /// <summary>
    /// Interface sales service
    /// </summary>
    public interface ISalesServices
    {
        /// <summary>
        /// Service sales history
        /// </summary>
        /// <returns>Object sales history</returns>
        Task<List<ResponseSalesModel>> GetSalesASync();
    }
}
