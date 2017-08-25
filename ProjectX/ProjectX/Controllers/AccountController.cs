using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using AutoMapper;
using PX.Domain.DAC;
using PX.IService.IBLL;
using PX.Model.ViewModel;
using PX.Utility.Tool;

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

        /// <summary>
        /// User login
        /// </summary>
        /// <param name="userView">login information</param>
        /// <returns>login message</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Login(SysUserViewModel userView)
        {
            string msg = null;
            bool loginState = false;
            if (userView != null)
            {
                if (string.IsNullOrEmpty(userView.ValidateCode) ||
                    Session["ValidateCode"].ToString().ToLower() != userView.ValidateCode.ToLower())
                {
                    msg = "ValidateCode Wrong.";
                }
                else
                {
                    SysUser user = _sysUserService.GetList().FirstOrDefault(d => d.UserName == userView.UserName);
                    if (user == null)
                    {
                        msg = "UseName Wrong.";
                    }
                    else
                    {
                        if (user.Password != userView.Password)
                        {
                            msg = "Password Wrong.";
                        }
                        else
                        {
                            loginState = true;
                            //...
                        }
                    }
                }
            }

            var result = new
            {
                State = loginState,
                Message = msg
            };

            return Json(result);
        }

        /// <summary>
        /// Get validate code
        /// </summary>
        /// <returns>Validate Code</returns>
        public ActionResult GetValidateCode()
        {
            ValidateCode validateCode = new ValidateCode();
            string vCode = validateCode.RandCode();
            Session["ValidateCode"] = vCode;
            byte[] bytes = validateCode.CreateImage(vCode);

            return File(bytes, @"image/jpg");
        }
    }
}