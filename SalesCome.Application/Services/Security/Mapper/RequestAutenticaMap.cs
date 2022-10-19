using SalesCome.Application.Services.Security.Model;
using SalesCome.Infrastructure.Services.Autentica.Model;

namespace SalesCome.Application.Services.Security.Mapper
{
    public class RequestAutenticaMap
    {
        public AutenticaRequestModel Map(RequestAutenticaModel model)
        {
            return new AutenticaRequestModel()
            {
                NickName = model.NickName,
                CounterSing = model.CounterSing
            };
        }
    }
}
