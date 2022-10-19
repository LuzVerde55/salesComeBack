using SalesCome.Application.Services.Clients.Mapper;
using SalesCome.Application.Services.Clients.Model;
using SalesCome.Infrastructure.Services.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesCome.Application.Services.Clients
{
    /// <summary>
    /// Client service
    /// </summary>
    public class ClientServices : IClientServices
    {
        /// <summary>
        /// I servicer
        /// </summary>
        private readonly IClientService _clientService;

        /// <summary>
        /// Constructor client service
        /// </summary>
        /// <param name="clientService">Interface client</param>
        public ClientServices(IClientService clientService)
        {
            _clientService = clientService;
        }

        /// <summary>
        /// Save client
        /// </summary>
        /// <param name="model">Request Client</param>
        /// <returns>true or False</returns>
        public async Task<bool> SaveClientAsync(RequestClientModel model)
        {
            return await _clientService.SaveClientAsync(new ClientServiceMap().MapReq(model));
        }

        /// <summary>
        /// Update client
        /// </summary>
        /// <param name="model">Request Client</param>
        /// <returns>true or False</returns>
        public async Task<bool> UpdateClientAsync(RequestClientModel model)
        {
            return await _clientService.UpdateClientAsync(new ClientServiceMap().MapReq(model));
        }

        /// <summary>
        /// Delete client
        /// </summary>
        /// <param name="model">Request Client</param>
        /// <returns>true or False</returns>
        public async Task<bool> DeleteClientAsync(RequestClientModel model)
        {
            return await _clientService.DeleteClientAsync(new ClientServiceMap().MapReq(model));
        }

        /// <summary>
        /// Get clients
        /// </summary>
        /// <returns>Object client</returns>
        public async Task<List<ResponseClientModel>> GetClientsasync()
        {
            return new ClientServiceMap().MapListResp(await _clientService.GetClientsAsync());
        }

        /// <summary>
        /// Save ConctacInfo
        /// </summary>
        /// <param name="model">Request Client</param>
        /// <returns>true or False</returns>
        public async Task<bool> SaveConctacInfoAsync(RequestContactInfoModel model)
        {
            return await _clientService.SaveInfoContactAsync(new ClientServiceMap().MapContactInfoReq(model));
        }

        /// <summary>
        /// Update ConctacInfo
        /// </summary>
        /// <param name="model">Request Client</param>
        /// <returns>true or False</returns>
        public async Task<bool> UpdateConctacInfoAsync(RequestContactInfoModel model)
        {
            return await _clientService.UpdateInfoContactAsync(new ClientServiceMap().MapContactInfoReq(model));
        }

        /// <summary>
        /// Delete ConctacInfo
        /// </summary>
        /// <param name="model">Request Client</param>
        /// <returns>true or False</returns>
        public async Task<bool> DeleteConctacInfoAsync(RequestContactInfoModel model)
        {
            return await _clientService.DeleteInfoContactAsync(new ClientServiceMap().MapContactInfoReq(model));
        }

        /// <summary>
        /// Get ConctacInfo
        /// </summary>
        /// <returns>Object ConctacInfo</returns>
        public async Task<List<ResponseContactInfoModel>> GetConctacInfoasync(int clientId)
        {
            return new ClientServiceMap().MapListRespContactInfo(await _clientService.ContactInfoCollectionAsync(clientId));
        }

    }
}
