using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yardillocore;
using yardillocore.Models;

namespace Tidbits.Authentication
{
    public class BasicAuthFilter : Attribute, IAuthorizationFilter
    {
        private readonly string _realm = string.Empty;


        public BasicAuthFilter()
        {


            //_realm = realm;
            //if (string.IsNullOrWhiteSpace(_realm))
            //{
            //    throw new ArgumentNullException(nameof(realm), @"Please provide a non-empty realm value.");
            //}
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            IConfigurationBuilder builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var scrkey = configuration.GetSection("AppConfig").GetSection("YAuthSourceKey").Value;
            var keyval = configuration.GetSection("AppConfig").GetSection("YAuthSourceValue").Value;
            string srapidapikey = context.HttpContext.Request.Headers[scrkey];
            if (keyval == srapidapikey)
            {
                context.HttpContext.Session.SetString("mbadtanent", srapidapikey);
                return;
            }
            ReturnUnauthorizedResult(context);

        }

        private static void ReturnUnauthorizedResult(AuthorizationFilterContext context)
        {
            // Return 401 and a basic authentication challenge (causes browser to show login dialog)
            context.HttpContext.Response.Headers["WWW-Authenticate"] = $"Basic realm=\"{""}\"";
            context.Result = new UnauthorizedResult();
        }



    }
}
