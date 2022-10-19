using SalesCome.Application.Services.Sales.Mapper;
using SalesCome.Application.Services.Sales.Model;
using SalesCome.Infrastructure.Services.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesCome.Application.Services.Sales
{
    /// <summary>
    /// Class service sales
    /// </summary>
    public class SalesServices : ISalesServices
    {
        private readonly ISalesService _salesService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="salesService"></param>
        public SalesServices(ISalesService salesService)
        {
            _salesService = salesService;
        }

        /// <summary>
        /// Method by Get sales
        /// </summary>
        /// <returns>Object list sales</returns>
        public async Task<List<ResponseSalesModel>> GetSalesASync()
        {
            return new SalesServiceMap().MapList(await _salesService.GetHistorySalesAsync());
        }
    }
}
