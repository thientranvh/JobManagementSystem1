using System;
using System.Linq;
using System.Collections.Generic;
using AutoMapper;
using Serilog;
using JobManagementSystem.Common;
using JobManagementSystem.DataAccess.Models;
using JobManagementSystem.Service.GenericRepository;
using JobManagementSystem.Service;
using JobManagementSystem.DataModel.Models.UserModels;
using JobManagementSystem.Common.Resources;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;

        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="genericRepository"></param>
        public UserService(IMapper mapper, IGenericRepository<User> genericRepository)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;

        }

        /// <summary>
        ///Method LoadData return parameter provide properties for Action LoadDataController 
        /// </summary>
        /// <param name="dtParameters"></param>
        /// <returns></returns>
        //public Tuple<IEnumerable<UserViewModel>, int, int> LoadData(DTParameters dtParameters)
        //{
        //    var searchBy = dtParameters.Search?.Value;
        //    string orderCriteria;
        //    bool orderAscendingDirection;

        //    if (dtParameters.Order != null)
        //    {
        //        // in this example we just default sort on the 1st column
        //        orderCriteria = dtParameters.Columns[dtParameters.Order[0].Column].Data;
        //        orderAscendingDirection = dtParameters.Order[0].Dir.ToString().ToLower() == ParamConstants.Asc;
        //    }
        //    else
        //    {
        //        // if we have an empty search then just order the results by Id ascending
        //        orderCriteria = ParamConstants.Id;
        //        orderAscendingDirection = true;
        //    }

        //    var user = _genericRepository.GetAll();
        //    var usertViewModels = _mapper.Map<IEnumerable<UserViewModel>>(user);

        //    if (!string.IsNullOrEmpty(searchBy))
        //    {
        //        usertViewModels = usertViewModels.Where(r =>
        //                r.Id.ToString().ToUpper().Contains(searchBy.ToUpper()) ||
        //                r.FullName.ToUpper().Contains(searchBy.ToUpper()) ||
        //                r.Email.ToUpper().Contains(searchBy.ToUpper()) ||
        //                r.Status.ToString().ToUpper().Equals(searchBy.ToUpper()));
        //    }

        //    usertViewModels = orderAscendingDirection
        //        ? usertViewModels.AsQueryable().OrderByDynamic(orderCriteria, LinqExtensions.Order.Asc)
        //        : usertViewModels.AsQueryable().OrderByDynamic(orderCriteria, LinqExtensions.Order.Desc);

        //    var viewModels = usertViewModels.OrderByDescending(x => x.CreateAt).ToArray();
        //    var filteredResultsCount = viewModels.ToArray().Length;
        //    var totalResultsCount = user.Count();

        //    var tuple = new Tuple<IEnumerable<UserViewModel>, int, int>(viewModels, filteredResultsCount,
        //        totalResultsCount);

        //    return tuple;
        //}

        /// <summary>
        /// Method ChangeStatus User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ChangeStatus(int id)
        {
            var user = _genericRepository.GetById(id);
            user.Status = !user.Status;
            _genericRepository.Save();
            return user.Status;
        }
        /// <summary>
        /// Method GetDetail return UserViewModel provide property for View
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserViewModel GetDetail(int id)
        {
            var user = _mapper.Map<UserViewModel>(_genericRepository.GetById(id));
            return user;
        }

        /// <summary>
        /// Method Edit edit User
        /// </summary>
        /// <param name="userViewModel"></param>
        /// <returns></returns>
        public EditUserViewModel Edit(EditUserViewModel userViewModel)
        {
            try
            {
                var user = _genericRepository.GetById(userViewModel.Id);
                if (user == null) return null;
                user.Role = userViewModel.Role;
                user.Status = userViewModel.Status;
                _genericRepository.Save();
                var userResult = _mapper.Map<EditUserViewModel>(user);
                return userResult;
            }
            catch (Exception e)
            {
                Log.Error(e, UserResource.EditServiceLogError);
                throw;
            }
        }

        /// <summary>
        /// Method GetUserEdit return EditUserViewModel
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public EditUserViewModel GetUserEdit(int id)
        {
            var user = _mapper.Map<EditUserViewModel>(_genericRepository.GetById(id));
            return user;
        }
    }
}