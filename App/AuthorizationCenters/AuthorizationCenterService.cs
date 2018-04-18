using System;
using App.JWTHelpers;
using Core.Services;
using Core.Services.Dto;
using AutoMapper;
using Newtonsoft.Json;

namespace App.AuthorizationCenters
{
    public class AuthorizationCenterService : IAuthorizationCenterService
    {
        private static string key = "abcdefghijkmlopquABCDEFGHIJKLMN";

        public string DecodeToken(string token)
        {
            return JsonWebToken.Decode(token, key);
        }

        /// <summary>
        /// get token
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public string GetToken(AuthorizationInput input)
        {
            //校验用户信息是否正确，如果正确则返回签名信息
            var sigin = JsonWebToken.Encode(input, key, JwtHashAlgorithm.HS384);
            return sigin;
        }

        /// <summary>
        /// verify token info
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool VerifyToken(string token)
        {
            //获取用户信息
            var userNameAndPwd = JsonWebToken.Decode(token, key);
            //数据查询用户信息是否正确

            return true;
        }

        /// <summary>
        /// 获取授权信息
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public AuthorizationOutput GetAuthorizationInfo(string token)
        {
            var authorizationInfo = JsonWebToken.Decode(token, key);
            var authorizeInfo = JsonConvert.DeserializeObject<AuthorizationOutput>(authorizationInfo);
            return authorizeInfo;
        }
    }
}
