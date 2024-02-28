using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionAppNet6
{
    public class Function1
    {
        [FunctionName(nameof(Function1))]
        [FixedDelayRetry(-1, "00:05:00")]
        public void Run([QueueTrigger("myqueue-items")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
