using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

namespace CWS.Code.CWS
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CwswebHook
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("query")]
        public Query Query { get; set; }

        [JsonProperty("headers")]
        public Headers Headers { get; set; }

        [JsonProperty("bodyRaw")]
        public string BodyRaw { get; set; }

        [JsonProperty("body")]
        public Body Body { get; set; }
    }

    public partial class Body
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("authHash")]
        public string AuthHash { get; set; }

        [JsonProperty("products")]
        public List<Product> Products { get; set; }
    }

    public partial class Product
    {
        [JsonProperty("productId")]
        public Guid ProductId { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("prices")]
        public List<Price> Prices { get; set; }
    }

    public partial class Price
    {
        [JsonProperty("priceRangeLabel")]
        public string PriceRangeLabel { get; set; }

        [JsonProperty("price")]
        public double PricePrice { get; set; }
    }

    public partial class Headers
    {
        [JsonProperty("x-forwarded-for")]
        public string XForwardedFor { get; set; }

        [JsonProperty("x-forwarded-proto")]
        public string XForwardedProto { get; set; }

        [JsonProperty("x-forwarded-port")]

        public long XForwardedPort { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("x-amzn-trace-id")]
        public string XAmznTraceId { get; set; }

        [JsonProperty("content-length")]
 
        public long ContentLength { get; set; }

        [JsonProperty("accept")]
        public string Accept { get; set; }

        [JsonProperty("user-agent")]
        public string UserAgent { get; set; }

        [JsonProperty("content-type")]
        public string ContentType { get; set; }

        [JsonProperty("cache-control")]
        public string CacheControl { get; set; }

        [JsonProperty("pragma")]
        public string Pragma { get; set; }
    }

    public partial class Query
    {
    }
}
