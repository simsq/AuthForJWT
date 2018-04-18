using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    /// <summary>
    /// JWT头部信息
    /// </summary>
    public class JwtHeader
    {
        /// <summary>
        /// 声明类型，默认为jwt
        /// </summary>

        [JsonProperty("typ")]
        public string Type { get; set; }

        /// <summary>
        /// 声明加密的算法,通常直接使用 HMAC SHA256
        /// </summary>
        [JsonProperty("alg")]
        public string Alg { get; set; }

        public JwtHeader()
        {
            this.Type = "jwt";
            this.Alg = "HS256";
        }
    }
}
