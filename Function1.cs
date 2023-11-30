using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FirstCSharp_App
{
    public static class QueueFunction
    {
        [FunctionName("QueueFunction")]
        public static void Run([QueueTrigger("myQueue", Connection = "AzureWebJobsStorage")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed myQueueItem: {myQueueItem}");
        }
    }
}
