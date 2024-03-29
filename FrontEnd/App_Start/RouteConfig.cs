﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="guillemsola">
//   Guillem Solà WTFPL
// </copyright>
// <summary>
//   MVC routes configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FrontEnd.App_Start
{
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// MVC routes configuration.
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// The register routes.
        /// </summary>
        /// <param name="routes">
        /// The routes.
        /// </param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}