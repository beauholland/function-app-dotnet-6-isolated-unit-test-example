using FunctionApp1.Interfaces;
using FunctionApp1.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(s =>
    {
        s.AddTransient(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));
    })
    .Build();

//builder.Services.AddTransient(typeof(ILoggerAdapter<>), typeof(LoggerAdapter<>));

host.Run();
