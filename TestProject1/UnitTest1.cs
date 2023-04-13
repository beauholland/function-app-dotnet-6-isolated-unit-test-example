using Castle.Core.Logging;
using FunctionApp1;
using FunctionApp1.Interfaces;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NSubstitute;
using System.Net;
using System.Text;
using TestProject1.Mock;
using TestProject1.Mock.Extensions;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        public class NotesFunctionTests
        {
            private readonly FunctionGetEmployee _sut;
            private readonly ILoggerAdapter<FunctionGetEmployee> _logger = Substitute.For<ILoggerAdapter<FunctionGetEmployee>>();

            public NotesFunctionTests()
            {
                _sut = new FunctionGetEmployee(_logger);
            }

            [Fact]
            public async Task BeauTest()
            {
                //Arrange
                var requestData = MockHelpers.CreateHttpRequestData();

                //Act
                var sut = new FunctionGetEmployee(_logger);
                var response = sut.Run(requestData);
                var result = response.ReadHttpResponseData();

                //Assert
                Assert.Equal("Welcome to Azure Functions!", result);
            }

            //[Fact]
            //public async Task Post_ShouldReturnOkObjectResultWithCreatedNoteDetails_WhenCalledWithValidNoteDetails()
            //{
            //    //// Arrange
            //    //var expectedResult = new CreateNoteResponse
            //    //{
            //    //    Id = _newNoteId,
            //    //    LastUpdatedOn = _newNoteLastUpdatedOn,
            //    //    Title = _newNoteTitle,
            //    //    Body = _newNoteBody
            //    //};

            //    //_noteService.CreateNoteAsync(Arg.Any<CreateNoteOptions>(), Arg.Any<CancellationToken>()).Returns(new NoteDto
            //    //{
            //    //    Id = _newNoteId,
            //    //    Body = _newNoteBody,
            //    //    Title = _newNoteTitle,
            //    //    LastUpdatedOn = _newNoteLastUpdatedOn
            //    //});

            //    //// Act
            //    //var response = await _sut.Post(new CreateNoteRequest
            //    //{
            //    //    Title = _newNoteTitle,
            //    //    Body = _newNoteBody
            //    //});

            //    //// Assert
            //    //_logger.Received(1).LogInformation("C# HTTP trigger NotesFunction processed a request.");
            //    //var result = response.Result as CreatedResult;
            //    //result!.StatusCode.Should().Be(StatusCodes.Status201Created);
            //    //result!.Value.Should().BeEquivalentTo(expectedResult);
            //}

            //[Fact]
            //public async Task Post_ShouldReturnBadRequestObjectResultWithRespectiveErrorMessage_WhenCalledWithInvalidNoteDetails()
            //{
            //    //// Arrange
            //    //_noteService.CreateNoteAsync(Arg.Any<CreateNoteOptions>(), Arg.Any<CancellationToken>()).ReturnsNull();

            //    //// Act
            //    //var response = await _sut.Post(new CreateNoteRequest
            //    //{
            //    //    Title = _newNoteTitle,
            //    //    Body = _newNoteBody
            //    //});

            //    //// Assert
            //    //_logger.Received(1).LogInformation("C# HTTP trigger NotesFunction processed a request.");
            //    //var result = response.Result as BadRequestObjectResult;
            //    //result!.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
            //    //result!.Value.Should().BeEquivalentTo("This HTTP triggered NotesFunction executed successfully, but you passed in a bad request model for the note creation process.");
            //}

            //[Fact]
            //public async Task Post_ShouldLogTheExceptionAndReturnInternalServerError_WhenNoteServiceThrowsAnException()
            //{
            //    //// Arrange
            //    //_noteService.CreateNoteAsync(Arg.Any<CreateNoteOptions>(), Arg.Any<CancellationToken>()).ThrowsAsync<Exception>();

            //    //// Act
            //    //var response = await _sut.Post(new CreateNoteRequest
            //    //{
            //    //    Title = _newNoteTitle,
            //    //    Body = _newNoteBody
            //    //});

            //    //// Assert
            //    //_logger.Received(1).LogInformation("C# HTTP trigger NotesFunction processed a request.");
            //    //_logger.Received(1).LogError(Arg.Any<Exception>(), $"Exception in {nameof(NotesFunction)} -> {typeof(NotesFunction)!.GetMethod("Post")!.Name} method.");
            //    //var result = response.Result as InternalServerErrorResult;
            //    //result!.StatusCode.Should().Be(StatusCodes.Status500InternalServerError);
            //}
        }


        //// https://learn.microsoft.com/en-us/azure/azure-functions/functions-develop-vs?tabs=isolated-process#create-test-classes

        //private readonly ILogger logger = TestFactory.CreateLogger();

        //[Fact]
        //public async Task Http_trigger_should_return_known_string()
        //{
        //    var request = TestFactory.CreateHttpRequest("name", "Bill");
        //    var response = (OkObjectResult)await Function1.Run(request, logger);
        //    Assert.Equal("Hello, Bill. This HTTP triggered function executed successfully.", response.Value);
        //}

        //[Theory]
        //[MemberData(nameof(TestFactory.Data), MemberType = typeof(TestFactory))]
        //public async Task Http_trigger_should_return_known_string_from_member_data(string queryStringKey, string queryStringValue)
        //{
        //    var request = TestFactory.CreateHttpRequest(queryStringKey, queryStringValue);
        //    var response = (OkObjectResult)await Function1.Run(request, logger);
        //    Assert.Equal($"Hello, {queryStringValue}. This HTTP triggered function executed successfully.", response.Value);
        //}

        //[Fact]
        //public void Timer_should_log_message()
        //{
        //    var logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);
        //    new MyTimerTrigger().Run(null, logger);
        //    var msg = logger.Logs[0];
        //    Assert.Contains("C# Timer trigger function executed at", msg);
        //}
    }
}