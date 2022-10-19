using SalesCome.Infrastructure.Services.Sales.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesCome.Infrastructure.Services.Sales
{
    public interface ISalesService
    {
        Task<List<SalesResponseModel>> GetHistorySalesAsync();
    }
}
