namespace WebAPI
{
    using System.Web.Http;
    using WebAPI.Models.Extensions;

    /// <summary>
    /// Web API configurations
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers Custom HTTP Configurations
        /// </summary>
        /// <param name="config">
        /// An instance of HttpConfiguration
        /// </param>
        public static void Register(HttpConfiguration config)
        {
            config.ConfigureCors();
            config.ConfigureFormatters();

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
        }
    }
}
