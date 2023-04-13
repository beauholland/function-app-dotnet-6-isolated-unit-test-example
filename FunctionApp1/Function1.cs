using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class Function1
    {
        // https://learn.microsoft.com/en-us/azure/azure-functions/functions-develop-vs?tabs=isolated-process#create-test-classes

        // ORIGINAL
        //private readonly ILogger _logger;

        //public Function1(ILoggerFactory loggerFactory)
        //{
        //    _logger = loggerFactory.CreateLogger<Function1>();
        //}

        // WORKING
        private readonly ILogger<Function1> _logger;

        public Function1(ILogger<Function1> logger)
        {
            _logger = logger;
        }


        [Function("Function1")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            // var logger = req.FunctionContext.GetLogger<Function1>();

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
