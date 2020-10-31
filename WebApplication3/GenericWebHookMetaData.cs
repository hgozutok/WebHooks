using Microsoft.AspNetCore.WebHooks.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class GenericWebHookMetaData : WebHookMetadata, IWebHookFilterMetadata
    {
        private readonly GenericSignatureFilter _verifySignatureFilter;

        public GenericWebHookMetaData()
            : base(UnicornConstants.ReceiverName)
        {
           // _verifySignatureFilter = verifySignatureFilter;
        }
        public override WebHookBodyType BodyType => WebHookBodyType.Json;

        public void AddFilters(WebHookFilterMetadataContext context)
        {
            context.Results.Add(_verifySignatureFilter);
        }

        //public void AddFilters(WebHookFilterMetadataContext context)
        //{
        //    context.Results.Add(_verifySignatureFilter);
        //}
    }
}
