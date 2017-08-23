using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PX.Domain.DAC;
using PX.IService.IBLL;

namespace ProjectX.Controllers
{
    public class AccountController : Controller
    {
        private readonly ISysUserService _sysUserService;

        public AccountController(ISysUserService sysUserService)
        {
            _sysUserService = sysUserService;
        }

        public ActionResult Login()
        {
            #region 测试-添加一条记录

            //SysUser user = new SysUser
            //{
            //    ID = "001",
            //    UserName = "Dtipps",
            //    Password = "123",
            //    IsActive = true
            //};

            //_sysUserService.Create(user);

            //_sysUserService.SaveChanges();

            #endregion

            return View();
        }
    }
}