using SalesCome.Application.Services.Security.Mapper;
using SalesCome.Application.Services.Security.Model;
using SalesCome.Infrastructure.Services.Autentica;
using SalesCome.Infrastructure.Services.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesCome.Application.Services.Security
{
    /// <summary>
    /// class Security
    /// </summary>
    public class SecurityService : ISecurityService
    {
        private readonly IAutentica _autentica;
        private readonly IUserService _userService;

        /// <summary>
        /// Constructor class
        /// </summary>
        /// <param name="autentica">Service infra autentica</param>
        /// <param name="userService">Service infra users</param>
        public SecurityService(IAutentica autentica, IUserService userService)
        {
            _autentica = autentica;
            _userService = userService;
        }

        /// <summary>
        /// Method by validate user
        /// </summary>
        /// <param name="model">Model request</param>
        /// <returns>true or false</returns>
        public async Task<bool> ValidUserAsync(RequestAutenticaModel model)
        {
            RequestAutenticaMap mapp = new RequestAutenticaMap();
            return await _autentica.GetValidateUser(mapp.Map(model));
        }

        /// <summary>
        /// Method by Get users
        /// </summary>
        /// <returns>Object list Users</returns>
        public async Task<List<ResponseUserModel>> GetUsersAsync()
        {
            ResponseUserMap mapp = new ResponseUserMap();
            return mapp.MapList(await _userService.GetListUsersAsync());
        }

        /// <summary>
        /// Method by get Uniq User
        /// </summary>
        /// <param name="userId">User id validate</param>
        /// <returns>Object user</returns>
        public async Task<ResponseUserModel> GetUniqueUser(int userId)
        {
            ResponseUserMap mapp = new ResponseUserMap();
            return mapp.Map(await _userService.GetUniqUserAsync(userId));
        }
    }
}
