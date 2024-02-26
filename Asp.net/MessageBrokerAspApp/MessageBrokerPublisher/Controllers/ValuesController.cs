using MessageBrokerPublisher.Configurations;
using MessageBrokerPublisher.Models.DTOs;
using MessageBrokerPublisher.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageBrokerPublisher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController(IRabbitMQService rabbitMQService, RabbitMQConfiguration rabbitMQConfiguration) : ControllerBase
    {
        [HttpPost("test")]
        public IActionResult Test(TestDto request)
        {
            rabbitMQService.Publish<TestDto>(request, rabbitMQConfiguration.QueueName);
            return Ok();
        }

    }
}
