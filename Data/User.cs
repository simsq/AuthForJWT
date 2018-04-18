using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class User:EntityBase
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// MD5加密密码
        /// </summary>
        public string Password { get; set; }
    }
}
