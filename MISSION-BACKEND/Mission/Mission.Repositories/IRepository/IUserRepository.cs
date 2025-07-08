using Microsoft.EntityFrameworkCore;
using Mission.Entities.ViewModels.Login;
using Mission.Entities.ViewModels.User;

namespace Mission.Repositories.IRepository
{
    public interface IUserRepository
    {
        Task<(UserLoginResponseModel? response, string message)> LogiUser(UserLoginRequestModel model);
        Task<List<UserResponseModel>> GetUsersAsync();
    }

    

  }
