// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebApiConfig.cs" company="guillemsola">
//   Guillem Sola WTFPL
// </copyright>
// <summary>
//   Defines the WebApiConfig type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FrontEnd.App_Start
{
    using System.Web.Http;

    /// <summary>
    /// The web API config.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// The register.
        /// </summary>
        /// <param name="config">
        /// The config.
        /// </param>
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{path}",
                defaults: new { path = RouteParameter.Optional });
        }
    }
}
