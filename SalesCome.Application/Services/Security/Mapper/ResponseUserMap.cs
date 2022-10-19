using SalesCome.Application.Services.Security.Model;
using SalesCome.Infrastructure.Services.Users.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesCome.Application.Services.Security.Mapper
{
    public class ResponseUserMap
    {
        public ResponseUserModel Map(UserResponseModel model)
        {
            return new ResponseUserModel
            {
                UserId = model.UserId,
                UserInfo = model.UserInfo
            };
        }

        public List<ResponseUserModel> MapList(List<UserResponseModel> model)
        {
            return model.Select(s => new ResponseUserModel
            {
                UserId = s.UserId,
                UserInfo = s.UserInfo
            }).ToList();
        }
    }
}
