﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Server
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            SqlDependency.Start(ConfigurationManager.ConnectionStrings["painel_taxservices_dbContext"].ConnectionString);
            
            AuthConfig.RegisterAuth();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            /*if (this.Context.Request.Path.Contains("signalr/negotiate") || this.Context.Request.Path.Contains("signalr/start"))
            {
                //this.Context.Response.AddHeader("Access-Control-Allow-Origin", "http://127.0.0.1:58731/"); //"*");
                //this.Context.Response.AddHeader("Access-Control-Allow-Headers", "X-Requested-With, Content-Type, Accept");
                this.Context.Response.AddHeader("Access-Control-Allow-Methods", "GET ");
                this.Context.Response.AddHeader("Access-Control-Allow-Credentials", "true");
            }*/
        }

        protected void Application_End()
        {
            SqlDependency.Stop(ConfigurationManager.ConnectionStrings["painel_taxservices_dbContext"].ConnectionString);
        }
    }
}