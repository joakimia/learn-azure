using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace HelloWorld_Func_Test
{
    public static class TimerTrigger2
    {
        [FunctionName("TimerTrigger2")]
        public static void Run([TimerTrigger("*/20 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
