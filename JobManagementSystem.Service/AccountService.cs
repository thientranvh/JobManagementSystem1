using JobManagementSystem.Common;
using JobManagementSystem.Common.Infrastructure;
using JobManagementSystem.Common.Resources;
using JobManagementSystem.DataAccess.Models;
using JobManagementSystem.DataModel.Models.AccountModels;
using JobManagementSystem.Service.GenericRepository;
using Serilog;
using System;
using System.Linq;

namespace JobManagementSystem.Service
{
    public class AccountService : IAccountService
    {
        private readonly IGenericRepository<User> _repositoryUser;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="repositoryUser"></param>
        public AccountService(IGenericRepository<User> repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }

        /// <summary>
        /// Method Authentication given accountLoginModel and return User when Authen Success
        /// </summary>
        /// <param name="accountLoginModel"></param>
        /// <returns></returns>
        public User Authentication(AccountLoginModel accountLoginModel)
        {
            try
            {
                var user = _repositoryUser.Get(x =>
                    x.Email == accountLoginModel.Email && x.Password == Encryptor.Md5Hash(accountLoginModel.Password));
                return user;
            }
            catch (Exception e)
            {
                Log.Error(e, AccountResource.ErrorAuthentication);
                throw;
            }
        }

        /// <summary>
        /// Method Register, if success return User
        /// </summary>
        /// <returns></returns>
        public User RegisterUserModel(RegisterUserModel registerModel)
        {
            try
            {
                if (CheckExisted(registerModel)) return null;
                var account = new User
                {
                    Email = registerModel.Email,
                    Password = Encryptor.Md5Hash(registerModel.Password),
                    FullName = registerModel.FullName,
                    BirthDay = registerModel.BirthDay,
                    Address = registerModel.Address,
                    UpdateAt = DateTime.Now,
                    PhoneNumber = registerModel.PhoneNumber,
                    Role = (int)RoleEnum.Member,
                    Status = true,
                    CreateAt = DateTime.Now
                };
                _repositoryUser.Create(account);
                _repositoryUser.Save();
                var userResult = _repositoryUser.Get(x => x.Email == account.Email);
                return userResult;
            }
            catch (Exception e)
            {
                Log.Error(e, AccountResource.RegisterServiceLogError);
                return null;
            }
        }

        /// <summary>
        /// Method check UserModel Existed, if existed return true
        /// </summary>
        /// <returns></returns>
        private bool CheckExisted(RegisterUserModel registerModel)
        {
            return _repositoryUser.ObjectContext.Any(x => x.Email.Equals(registerModel.Email));
        }
    }
}
