using SalesCome.Infrastructure.Services.Clients.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalesCome.Infrastructure.Services.Clients
{
    public interface IClientService
    {
        Task<bool> SaveClientAsync(ClientRequestModel client);

        Task<bool> UpdateClientAsync(ClientRequestModel client);

        Task<bool> DeleteClientAsync(ClientRequestModel client);

        Task<List<ClientResponseModel>> GetClientsAsync();
        
        Task<bool> SaveInfoContactAsync(ContactInfoRequestModel contact);

        Task<bool> UpdateInfoContactAsync(ContactInfoRequestModel contact);

        Task<bool> DeleteInfoContactAsync(ContactInfoRequestModel contact);

        Task<List<ContactInfoResponseModel>> ContactInfoCollectionAsync(long ClientId);
    }
}
