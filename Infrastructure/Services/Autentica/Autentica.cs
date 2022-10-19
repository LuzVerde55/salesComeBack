using SalesCome.DAC.DBContext;
using SalesCome.Infrastructure.Services.Autentica.Model;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SalesCome.Infrastructure.Services.Autentica
{
    public class Autentica : IAutentica
    {
        private readonly ISalesContext _salesContext;

        public Autentica(ISalesContext salesContext)
        {
            _salesContext = salesContext;
        }

        public async Task<bool> GetValidateUser(AutenticaRequestModel autentica)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@Nick", SqlDbType = SqlDbType.NVarChar, Value = autentica.NickName},
                new SqlParameter { ParameterName = "@CounterSing", SqlDbType = SqlDbType.NVarChar, Value = autentica.CounterSing}
            };

            DataSet ds = await _salesContext.Fill("db_security.sp_Access", parameters);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                var row = ds.Tables[0].Rows[0];
                if (int.Parse(row["Result"].ToString()) == 1)
                    return true;
                else
                    return false;
            }
            else return false;
        }
    }
}
