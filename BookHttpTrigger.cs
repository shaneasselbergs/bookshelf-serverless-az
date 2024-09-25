using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace My.Function
{
  public class BookHttpTrigger
  {
    private readonly ILogger<BookHttpTrigger> _logger;

    public BookHttpTrigger(ILogger<BookHttpTrigger> logger)
    {
      _logger = logger;
    }

    [Function("GetBooks")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "book")] HttpRequest req)
    {
      _logger.LogInformation("C# HTTP trigger function processed a request.");
      return new OkObjectResult("Welcome to Azure Functions!");
    }
  }
}
