using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;
using Microsoft.AspNetCore.WebHooks;

namespace WebApplication3
{
    public class GenericWebHookAttribute : WebHookAttribute
    {
        public GenericWebHookAttribute() : base(UnicornConstants.ReceiverName)
        {
        }
    }
    public static class UnicornConstants
    {
        public const string ReceiverName = "hugo";
        public const string SignatureHeaderName = "X-Sig-Header";
    }
}
