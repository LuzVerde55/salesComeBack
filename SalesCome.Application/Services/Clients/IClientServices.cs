using SalesCome.Application.Services.Clients.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesCome.Application.Services.Clients
{
    /// <summary>
    /// Interface Client Services
    /// </summary>
    public interface IClientServices
    {
        /// <summary>
        /// method Save client
        /// </summary>
        /// <param name="model">Object cleint request</param>
        /// <returns>true or false</returns>
        Task<bool> SaveClientAsync(RequestClientModel model);
        /// <summary>
        /// method Update client
        /// </summary>
        /// <param name="model">Object cleint request</param>
        /// <returns>true or false</returns>
        Task<bool> UpdateClientAsync(RequestClientModel model);
        /// <summary>
        /// method Delete client
        /// </summary>
        /// <param name="model">Object cleint request</param>
        /// <returns>true or false</returns>
        Task<bool> DeleteClientAsync(RequestClientModel model);
        /// <summary>
        /// Method by get all clients
        /// </summary>
        /// <returns>Ocject clients</returns>
        Task<List<ResponseClientModel>> GetClientsasync();
        /// <summary>
        /// method Save client
        /// </summary>
        /// <param name="model">Object contact info request</param>
        /// <returns>true or false</returns>
        Task<bool> SaveConctacInfoAsync(RequestContactInfoModel model);
        /// <summary>
        /// method Update client
        /// </summary>
        /// <param name="model">Object contact info request</param>
        /// <returns>true or false</returns>
        Task<bool> UpdateConctacInfoAsync(RequestContactInfoModel model);
        /// <summary>
        /// method Delete client
        /// </summary>
        /// <param name="model">Object contact info request</param>
        /// <returns>true or false</returns>
        Task<bool> DeleteConctacInfoAsync(RequestContactInfoModel model);
        /// <summary>
        /// Get contact info
        /// </summary>
        /// <param name="clientId">Id Client asoc Info</param>
        /// <returns>Object Contact info</returns>
        Task<List<ResponseContactInfoModel>> GetConctacInfoasync(int clientId);
    }
}
