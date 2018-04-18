using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    /// <summary>
    /// JWT请求体
    /// </summary>
    public class JwtPayload
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        public JwtPayload():base()
        {

        }

        public JwtPayload(int userId) : this()
        {
            this.UserId = UserId;
        }
    }

    /// <summary>
    /// JWT Payload声明的标准信息
    /// </summary>
    public abstract class JwtPayloadBase
    {
        private readonly string all = "*";

        /// <summary>
        /// JWT签发者
        /// </summary>
        [JsonProperty("iss")]
        public string Iss { get; set; }

        /// <summary>
        /// JWT所面向的用户
        /// </summary>
        [JsonProperty("sub")]
        public string Sub { get; set; }

        /// <summary>
        /// 接受JWT的一方
        /// </summary>
        [JsonProperty("aud")]
        public string Aud { get; set; }

        /// <summary>
        /// 过期时间，默认为签发时间后的两小时内
        /// </summary>
        [JsonProperty("exp")]
        public DateTime? Exp { get; set; }

        /// <summary>
        /// 定义在什么时间之前，该jwt都是不可用的.
        /// </summary>
        [JsonProperty("nbf")]
        public DateTime? Nbf { get; set; }

        /// <summary>
        /// jwt的签发时间
        /// </summary>
        [JsonProperty("iat")]
        public DateTime? Iat { get; set; }

        /// <summary>
        /// jwt的唯一身份标识，主要用来作为一次性token,从而回避重放攻击
        /// </summary>
        [JsonProperty("jti")]
        public string Jti { get; set; }

        public JwtPayloadBase()
        {
            this.Iss = all;
            this.Sub = all;
            this.Aud = all;
            this.Exp = DateTime.Now.AddHours(2);
            this.Nbf = DateTime.Now;
            this.Iat = DateTime.Now;
            this.Jti = all;

        }
    }
}
