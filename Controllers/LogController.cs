using Microsoft.AspNetCore.Mvc;

namespace Homework.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("log")]
        public IEnumerable<ApiCallLog> Get()
        {
            var apiLogs = new List<ApiCallLog>()
            {
                new ApiCallLog
                {
                    Timetamp = DateTime.Now,
                    Body ="sds",
                    Description = "dsds",
                    RowKey = Guid.NewGuid().ToString(),
                    PartitionKey = "Error"
                },
                new ApiCallLog
                {
                    Timetamp = DateTime.Now,
                    Body ="sds",
                    Description = "dsds",
                    RowKey = Guid.NewGuid().ToString(),
                    PartitionKey = "Info"
                }
            };

            return apiLogs;
        }
    }
}