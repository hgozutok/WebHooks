using Microsoft.AspNetCore.WebHooks.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class GenericWebHookMetaData : WebHookMetadata, IWebHookFilterMetadata
    {
       // private readonly UnicornVerifySignatureFilter _verifySignatureFilter;

        public GenericWebHookMetaData()
            : base("hugo")
        {
           // _verifySignatureFilter = verifySignatureFilter;
        }
        public override WebHookBodyType BodyType => WebHookBodyType.Json;

        public void AddFilters(WebHookFilterMetadataContext context)
        {
           
        }

        //public void AddFilters(WebHookFilterMetadataContext context)
        //{
        //    context.Results.Add(_verifySignatureFilter);
        //}
    }
}
