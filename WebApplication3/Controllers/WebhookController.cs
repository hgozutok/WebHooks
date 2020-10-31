using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ApiWorkMvc.Code.CodesWholesale;
using CWS.Code.CWS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {

        [CwsHook]
        [HttpPost]
       public async Task<IActionResult> Hugo(string @event, object data)
        //   public async Task<IActionResult> Hugo(string @event,   CwsHook hook )
        {
            if (data.ToString().Contains("STOCK"))
            {
                CwsHook cwswebHook = Newtonsoft.Json.JsonConvert.DeserializeObject<CwsHook>(data.ToString());


                foreach (var item in cwswebHook.Products)
                {

                }
            }
            else
            {
                if (data.ToString().Contains("NEW_PRODUCT"))
                {
                    CwsHookEdit cwswebHook = Newtonsoft.Json.JsonConvert.DeserializeObject<CwsHookEdit>(data.ToString());
                }
                else
                {
                    if (data.ToString().Contains("PRODUCT_UPDATED"))
                    {
                        CwsHookEdit cwswebHook = Newtonsoft.Json.JsonConvert.DeserializeObject<CwsHookEdit>(data.ToString());
                    }
                }

            }
         
         //   hook = JsonSerializer.Deserialize<CwswebHook>(data.ToString());
         //do something with the data
            return Ok();
        }



        // GET: api/<WebhookController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WebhookController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WebhookController>
        //[HttpPost]
        public void Post([FromBody] string value)
        {
            //   char[] a = value.ToCharArray();
            
            Response.Body.WriteByte(Convert.ToByte(value));
        }

        // PUT api/<WebhookController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WebhookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
