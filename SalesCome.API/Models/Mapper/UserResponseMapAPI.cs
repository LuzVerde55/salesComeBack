using SalesCome.API.Models.Security;
using SalesCome.Application.Services.Security.Model;
using System.Collections.Generic;
using System.Linq;

namespace SalesCome.API.Models.Mapper
{
    public class UserResponseMapAPI
    {
        public ResponseUserModelAPI Map(ResponseUserModel model)
        {
            return new ResponseUserModelAPI
            {
                UserId = model.UserId,
                UserInfo = model.UserInfo
            };
        }

        public List<ResponseUserModelAPI> MapList(List<ResponseUserModel> model)
        {
            return model.Select(s => new ResponseUserModelAPI
            {
                UserId = s.UserId,
                UserInfo = s.UserInfo
            }).ToList();
        }
    }
}
