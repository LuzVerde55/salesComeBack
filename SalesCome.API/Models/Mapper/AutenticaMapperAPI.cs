using SalesCome.API.Models.Security;
using SalesCome.Application.Services.Security.Model;

namespace SalesCome.API.Models.Mapper
{
    public class AutenticaMapperAPI
    {
        public RequestAutenticaModel Map(RequestAutenticaModelAPI model)
        {
            return new RequestAutenticaModel()
            {
                NickName = model.NickName,
                CounterSing = model.CounterSing
            };
        }
    }
}
