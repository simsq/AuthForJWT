using Core.Services.Dto;

namespace Core.Services
{
    /// <summary>
    /// 授权中心接口
    /// </summary>
    public interface IAuthorizationCenterService
    {
        /// <summary>
        /// 获取签名token
        /// </summary>
        /// <param name="userName">账号</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        string GetToken(AuthorizationInput input);

        /// <summary>
        /// 校验token是否通过
        /// </summary>
        /// <param name="key"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        bool VerifyToken(string token);

        /// <summary>
        /// 获取Authorization信息
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>

        AuthorizationOutput GetAuthorizationInfo(string token);
    }
}
