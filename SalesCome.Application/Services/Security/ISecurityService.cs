using SalesCome.Application.Services.Security.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesCome.Application.Services.Security
{
    /// <summary>
    /// Interface Security services
    /// </summary>
    public interface ISecurityService
    {
        /// <summary>
        /// Method by validate user
        /// </summary>
        /// <param name="model">Model request</param>
        /// <returns>True or False</returns>
        Task<bool> ValidUserAsync(RequestAutenticaModel model);
        /// <summary>
        /// Method by get users
        /// </summary>
        /// <returns>object list</returns>
        Task<List<ResponseUserModel>> GetUsersAsync();
        /// <summary>
        /// Method by get unique user
        /// </summary>
        /// <param name="userId">Useri id by filter</param>
        /// <returns>Object</returns>
        Task<ResponseUserModel> GetUniqueUser(int userId);
    }
}
