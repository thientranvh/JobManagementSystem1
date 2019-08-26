using AutoMapper;
using JobManagementSystem.DataAccess.Models;
using JobManagementSystem.DataModel.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.DataModel.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
             CreateMap<User, UserViewModel>()
                .ForMember(vm => vm.CreateBy, m => m.MapFrom(u => u.FullName))
                .ForMember(vm => vm.UpdateBy, m => m.MapFrom(u => u.FullName))
                .ForMember(vm => vm.Role, m => m.MapFrom(u => u.Role == 1 ? "Admin" : "Member"))
                .ForMember(vm => vm.Gender, m => m.MapFrom(u => u.Gender? "Nam" : "Nữ"));
            CreateMap<User, EditUserViewModel>();
        }
    }
}
