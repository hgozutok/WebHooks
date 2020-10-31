using Microsoft.AspNetCore.WebHooks.Metadata;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public static class GenericServiceCollectionSetup
    {
        public static void AddGenericServices(IServiceCollection services)
        {
            WebHookMetadata.Register<GenericWebHookMetaData>(services);
            services.AddSingleton<GenericSignatureFilter>();
        }
    }
}
