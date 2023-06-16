using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
	.ConfigureFunctionsWorkerDefaults(builder =>
	{
		//builder
		//	.AddApplicationInsights(options =>
		//	{
		//		// Configure the underlying ApplicationInsightsServiceOptions
		//		// This property configuration serves solely for demonstration purposes, and it is not mandatory to replicate the same property and its associated value in your own application.
		//		options.ApplicationVersion = "v1";
		//	})
		//	.AddApplicationInsightsLogger();
	})
	.ConfigureServices(s =>
	{
		//s.AddSingleton<IHttpResponderService, DefaultHttpResponderService>();
		//s.Configure<LoggerFilterOptions>(options =>
		//{
		//	// The Application Insights SDK adds a default logging filter that instructs ILogger to capture only Warning and more severe logs. Application Insights requires an explicit override.
		//	// Log levels can also be configured using appsettings.json. For more information, see https://learn.microsoft.com/en-us/azure/azure-monitor/app/worker-service#ilogger-logs
		//	LoggerFilterRule toRemove = options.Rules.FirstOrDefault(rule => rule.ProviderName
		//		== "Microsoft.Extensions.Logging.ApplicationInsights.ApplicationInsightsLoggerProvider");

		//	if (toRemove is not null)
		//	{
		//		options.Rules.Remove(toRemove);
		//	}
		//});
	})
	.Build();