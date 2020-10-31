using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json;

namespace ApiWorkMvc.Code.CodesWholesale
{

    public class CwsHookAttribute : Attribute
    {
    }
    public partial class CwsHook 
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("authHash")]
        public string AuthHash { get; set; }

        [JsonProperty("products")]
        public List<CWSHookProduct> Products { get; set; }
    }

    public partial class CWSHookProduct
    {
        [JsonProperty("productId")]
        public Guid ProductId { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("prices")]
        public List<CWSHookPrice> Prices { get; set; }
    }

    public partial class CWSHookPrice
    {
        [JsonProperty("priceRangeLabel")]
        public string PriceRangeLabel { get; set; }

        [JsonProperty("price")]
        public double PricePrice { get; set; }
    }

    public class CustomWebHookHandler : WebHookHandler
    {
        public CustomWebHookHandler()
        {
            this.Receiver = "hugo";// CustomWebHookReceiver.ReceiverName;
        }

        public override Task ExecuteAsync(string generator, WebHookHandlerContext context)
        {
            // Get data from WebHook
            //  CustomNotifications data = context.GetDataOrDefault<CustomNotifications>();
            CwsHook data = context.GetDataOrDefault<CwsHook>();
            // Get data from each notification in this WebHook
            foreach (CWSHookProduct product in data.Products)
            {
                // Process data
            }

            return Task.FromResult(true);
        }
    }

    public partial class CwsHookEdit
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("authHash")]
        public string AuthHash { get; set; }

        [JsonProperty("productId")]
        public string productId { get; set; }
    }

}
