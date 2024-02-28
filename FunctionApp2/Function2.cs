//using System;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Azure.WebJobs.Host;
//using Microsoft.Extensions.Logging;

//namespace FunctionApp2
//{
//    public class Function2
//    {
//        [FunctionName(nameof(Function2))]
//        public void Run([QueueTrigger("myqueue-items")]string myQueueItem, ILogger log)
//        {
//            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
//        }
//    }
//}
