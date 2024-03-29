﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="guillemsola">
//   Guillem Solà WTFPL
// </copyright>
// <summary>
//   The MVC application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FrontEnd
{
    using System.Web.Http;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using FrontEnd.App_Start;

    /// <summary>
    /// The MVC application.
    /// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    /// visit http://go.microsoft.com/?LinkId=9394801
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// The application_ start.
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}