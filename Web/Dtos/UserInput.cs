using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Dtos
{
    /// <summary>
    /// 用户账号输入Dto
    /// </summary>
    public class UserInput
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// md5加密密码
        /// </summary>
        public string Password { get; set; }
    }
}