using App.AuthorizationCenters;
using Core.Services;
using Core.Services.Dto;
using Kudi.Core.ApiModels;
using System.Web.Http;

namespace Web.Controllers
{
    public class AuthorizationController : ApiController
    {
        private readonly IAuthorizationCenterService _authorizationCenter;

        private AuthorizationController()
        {
            _authorizationCenter = new AuthorizationCenterService();
        }

        /// <summary>
        /// 获取签名
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/Authorization/GetToken")]
        public ApiResponseBase GetToken(AuthorizationInput input)
        {

            var result = new ApiResponse()
            {
                Data = _authorizationCenter.GetToken(input)
            };
            return result;
        }

        /// <summary>
        /// 校验签名是否通过
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Authorization/DecodeToken")]
        public ApiResponseBase DecodeToken(string token)
        {
            var result = new ApiResponse()
            {
                Data = _authorizationCenter.VerifyToken(token)
            };
            return result;
        }


        /// <summary>
        /// 根据Token获取授权信息
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Authorization/GetAuthorizationInfo")]
        public ApiResponseBase GetAuthorizationInfo(string token)
        {
            return new ApiResponse()
            {
                Data = _authorizationCenter.GetAuthorizationInfo(token)
            };
        }

    }
}
