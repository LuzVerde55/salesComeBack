using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SalesCome.DAC.DBContext
{
    public interface IConnectionDataAccess
    {
        Task<int> ExecuteNonQueryAsync(string procedure, params SqlParameter[] parameters);
        Task<DataSet> Fill(string procedure, params SqlParameter[] parameters);
        Task<DataSet> Views(string viewName);
    }
}
