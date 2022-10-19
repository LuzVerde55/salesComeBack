using Microsoft.Extensions.Configuration;

namespace SalesCome.DAC.DBContext
{
    public class SalesContext : ConnectionDataAccess, ISalesContext
    {
        public SalesContext(IConfiguration config, string database) : base(config, database)
        {
        }
    }
}
