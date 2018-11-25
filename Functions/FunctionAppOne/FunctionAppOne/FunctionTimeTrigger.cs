using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;

namespace FunctionAppOne
{
	public static class FunctionTimeTrigger
	{
		[FunctionName("FunctionTimeTrigger")]
		public static void Run([TimerTrigger("*/10 * * * * *")]TimerInfo myTimer, ILogger log)
		{
			// function will trigger at every 10 seconds
			log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
		}
	}
}
