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

             //yardillocore.Authorization.OnBasicAPIAuth(context, builder);
            yardillocore.Authorization.OnRapidHubAuth(context, builder);

            //IConfigurationRoot configuration = builder.Build();
            //var user = configuration.GetSection("DatabaseSettings").GetSection("ConnectionString").Value;
            //var pass = configuration.GetSection("AppConfig").GetSection("pass").Value;

            return;
        }
        

    }
}
