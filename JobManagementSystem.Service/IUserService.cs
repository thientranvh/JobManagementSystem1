using JobManagementSystem.DataModel.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.Service
{
    public interface IUserService
    {
        /// <summary>
        /// Method LoadData return tuple UserViewModel int int
        /// </summary>
        /// <param name="dtParameters"></param>
        /// <returns></returns>
        //Tuple<IEnumerable<UserViewModel>, int, int> LoadData(DTParameters dtParameters);

        /// <summary>
        /// Method ChangeStatus User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool ChangeStatus(int id);

        /// <summary>
        /// Method GetDetail return UserViewModel provide property for View
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserViewModel GetDetail(int id);

        /// <summary>
        /// Method Edit edit User
        /// </summary>
        /// <param name="userViewModel"></param>
        /// <returns></returns>
        EditUserViewModel Edit(EditUserViewModel userViewModel);

        /// <summary>
        /// Method GetUserEdit return EditUserViewModel
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        EditUserViewModel GetUserEdit(int id);
    }
}