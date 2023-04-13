using System.Net;
using FunctionApp1.Contracts.Requests;
using FunctionApp1.Contracts.Responses;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class FunctionPostEmployee
    {
        private readonly ILogger _logger;

        public FunctionPostEmployee(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<FunctionPostEmployee>();
        }

        //[Function("FunctionPostEmployee")]
        ////public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        //public HttpResponseData Post([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "employee")] HttpRequestData req)
        //{
        //    _logger.LogInformation("C# HTTP trigger function processed a request.");

        //    try
        //    {

        //        var response = req.CreateResponse(HttpStatusCode.OK);
        //        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

        //        response.WriteString("Welcome to Azure Functions!");

        //        //if (newNoteDto is null)
        //        //{
        //        //    return new BadRequestObjectResult("This HTTP triggered NotesFunction executed successfully, but you passed in a bad request model for the note creation process.");
        //        //}

        //        return new CreatedResult("/notes/" + newNoteDto.Id, new CreateNoteResponse
        //        {
        //            Id = newNoteDto.Id,
        //            Title = newNoteDto.Title,
        //            Body = newNoteDto.Body,
        //            LastUpdatedOn = newNoteDto.LastUpdatedOn
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Exception in {nameof(NotesFunction)} -> {nameof(Post)} method.");

        //        return new InternalServerErrorResult();
        //    }
        //}
    }
}
