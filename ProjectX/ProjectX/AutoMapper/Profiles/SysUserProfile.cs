using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PX.Domain.DAC;
using PX.Model.ViewModel;

namespace ProjectX.AutoMapper.Profiles
{
    public class SysUserProfile : Profile
    {
        public SysUserProfile()
        {
            CreateMap<SysUser, SysUserViewModel>();
            //CreateMap<SysUserViewModel, SysUser>();
        }
    }
}