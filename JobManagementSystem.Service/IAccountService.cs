using JobManagementSystem.DataAccess.Models;
using JobManagementSystem.DataModel.Models.AccountModels;

namespace JobManagementSystem.Service
{
    public interface IAccountService
    {
        /// <summary>
     /// Method Authentication given accountLoginModel and return User when Authen Success
     /// </summary>
     /// <param name="accountLoginModel"></param>
     /// <returns></returns>
        User Authentication(AccountLoginModel accountLoginModel);

        /// <summary>
        /// Method Register, if success return User
        /// </summary>
        /// <returns></returns>
        User RegisterUserModel(RegisterUserModel registerModel);
    }
}
