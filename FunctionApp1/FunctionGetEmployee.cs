using System.Net;
using FunctionApp1.Interfaces;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class FunctionGetEmployee
    {
        // https://learn.microsoft.com/en-us/azure/azure-functions/functions-develop-vs?tabs=isolated-process#create-test-classes

        // ORIGINAL
        //private readonly ILogger _logger;

        //public Function1(ILoggerFactory loggerFactory)
        //{
        //    _logger = loggerFactory.CreateLogger<Function1>();
        //}

        // WORKING
        private readonly ILoggerAdapter<FunctionGetEmployee> _logger;

        public FunctionGetEmployee(ILoggerAdapter<FunctionGetEmployee> logger)
        {
            _logger = logger;
        }


        [Function("FunctionGetEmployee")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "employee")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            // var logger = req.FunctionContext.GetLogger<FunctionGetEmployee>();

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
