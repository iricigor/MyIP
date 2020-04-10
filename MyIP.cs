using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;

namespace MyIP
{
    public static class MyIP
    {
        [FunctionName("MyIP")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            try
            {
                var remoteIpAddress = req.HttpContext.Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4();
                return (ActionResult)new OkObjectResult(remoteIpAddress.ToString());
            }
            catch
            {
                return new BadRequestObjectResult("Cannot find IP address!");
            }
        }
    }
}
