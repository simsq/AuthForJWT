using App;
using Kudi.Core.Modules;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Web
{
    public class WebModule : KudiModule
    {

        public HttpConfiguration HttpConfiguration { get; set; }
        public WebModule()
        {
            HttpConfiguration = GlobalConfiguration.Configuration;
        }

        public override void PostInitialize()
        {
            RegisterFilters(HttpConfiguration);

            //autoMapping
            var autoMappingConfiguration = new AutoMappingConfiguration();
            autoMappingConfiguration.CreateMaps();

            //默认使用Newtonsoft序列化
            var formatter = HttpConfiguration.Formatters.JsonFormatter;
            formatter.SerializerSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            //解决json序列化时，Json返回日期带T无法格式化的问题
            HttpConfiguration.Formatters.JsonFormatter
                                            .SerializerSettings
                                            .Converters.Add(
                                            new IsoDateTimeConverter
                                            {
                                                DateTimeFormat = "yyyy'-'MM'-'dd' 'HH':'mm':'ss"
                                            });
        }

        private void RegisterFilters(HttpConfiguration HttpConfiguration)
        {
            //HttpConfiguration.Filters.Add(new ApiExceptionFilter()); 

            //var timingActionFilter = new TimingActionFilter()
            //{
            //    TracingLog = (e) =>
            //    {
            //        var json = e.ToJson();
            //        LogHelper.Write(json);
            //    }
            //};
            //HttpConfiguration.Filters.Add(timingActionFilter);
        }
    }
}