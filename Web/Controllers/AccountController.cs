using Kudi.Core.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Web.Dtos;

namespace Web.Controllers
{
    /// <summary>
    /// 账号控制器
    /// </summary>
    public class AccountController:ApiController
    {
        public AccountController()
        {

        }
        public ApiResponse<string> Login(UserInput user)
        {
            return null;
        }  
    }
}