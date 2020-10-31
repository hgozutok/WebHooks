using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public static class GenericMvcCoreBuilderExtension
    {
        public static IMvcCoreBuilder AddUnicornWebHooks(this IMvcCoreBuilder builder)
        {
            GenericServiceCollectionSetup.AddGenericServices(builder.Services);
            return builder.AddWebHooks();
                //.AddJsonFormatters();
        }
    }
}
