using SalesCome.DAC.DBContext;
using SalesCome.Infrastructure.Services.Cache;
using SalesCome.Infrastructure.Services.Users.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SalesCome.Infrastructure.Services.Users
{
    public class UserService : IUserService
    {
        private readonly ICacheService _cacheService;
        private readonly ISalesContext _salesContext;

        public UserService(ICacheService cacheService, ISalesContext salesContext)
        {
            _cacheService = cacheService;
            _salesContext = salesContext;
        }

        public async Task<List<UserResponseModel>> GetListUsersAsync()
        {
            List<UserResponseModel> users;

            users = _cacheService.Get<List<UserResponseModel>>("GetListUsers");

            if (users is null)
            {
                DataSet ds = await _salesContext.Views("db_security.VW_Users");

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    users = new List<UserResponseModel>();

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UserResponseModel userResponse = new UserResponseModel()
                        {
                            UserId = int.Parse(dr["IdUser"].ToString()),
                            UserInfo = dr["UserInfo"].ToString()
                        };

                        users.Add(userResponse);
                    }

                    _cacheService.Insert("GetListUsers", users);
                }
            }

            return users;
        }

        public async Task<UserResponseModel> GetUniqUserAsync(int userId)
        {
            UserResponseModel user = new UserResponseModel();

            var parameters = new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@IdUser", SqlDbType = SqlDbType.Int, Value = userId}
            };

            DataSet ds = await _salesContext.Fill("db_security.sp_UniqUser", parameters);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    user.UserId = int.Parse(dr["IdUser"].ToString());
                    user.UserInfo = dr["UserInfo"].ToString();
                }
            }

            return user;
        }
    }
}
