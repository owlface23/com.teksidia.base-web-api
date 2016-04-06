using System.Web.Http;
using Owin;
using Swashbuckle.Application;

namespace JBC.BasicWebAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var httpConfiguration = new HttpConfiguration();
            httpConfiguration.MapHttpAttributeRoutes();
            httpConfiguration
            .EnableSwagger(c => c.SingleApiVersion("v1", "JBC.BasicWebAPI"))
            .EnableSwaggerUi(); 
            appBuilder.UseWebApi(httpConfiguration);
        }
    }
}