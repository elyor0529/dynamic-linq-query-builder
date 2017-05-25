﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Castle.DynamicLinqQueryBuilder.Samples
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional }
            );
        }
    }
}
