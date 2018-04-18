using Kudi.Core.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Web
{
    public class WebApiApplication : KudiWebApiApplication<WebModule>
    {
        protected override void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ///自定义
            WebModule webModule = new WebModule();
            webModule.PostInitialize();
        }

        /// 当开始一个请求时，ASP.NET 系统将自动调用该方法
        /// </summary>
        /// <param name = "sender" ></ param >
        /// < param name="e"></param>
        protected override void Application_BeginRequest(object sender, EventArgs e)
        {
            base.Application_BeginRequest(sender, e);
        }
    }
}
