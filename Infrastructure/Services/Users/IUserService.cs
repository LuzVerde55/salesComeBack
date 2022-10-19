using SalesCome.Infrastructure.Services.Users.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SalesCome.Infrastructure.Services.Users
{
    public interface IUserService
    {
        Task<List<UserResponseModel>> GetListUsersAsync();

        Task<UserResponseModel> GetUniqUserAsync(int userId);
    }
}
