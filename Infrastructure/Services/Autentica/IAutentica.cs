using SalesCome.Infrastructure.Services.Autentica.Model;
using System.Threading.Tasks;

namespace SalesCome.Infrastructure.Services.Autentica
{
    public interface IAutentica
    {
        Task<bool> GetValidateUser(AutenticaRequestModel autentica);
    }
}
