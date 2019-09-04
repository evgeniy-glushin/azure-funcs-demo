using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public static class OnOrderCreated
    {
        [FunctionName("OnOrderCreated")]
        public static async Task Run(
            [QueueTrigger("orders", Connection = "AzureWebJobsStorage")] Order order,
            //[Blob("licenses/{rand-guid}.lic")] TextWriter outputBlob,
            IBinder binder,
            ILogger log)
        {
            var outputBlob = await binder.BindAsync<TextWriter>(
                new BlobAttribute($"licenses/{order.Number}.lic")
                //{ Connection = "Any Connection" }
            );

            outputBlob.WriteLine($"Order Number: {order.Number}");
            outputBlob.WriteLine($"Customer Name: {order.CustomerName}");
            outputBlob.WriteLine($"Email: {order.CustomerEmail}");
            outputBlob.WriteLine($"Date: {DateTime.Now}");
        }
    }
}
