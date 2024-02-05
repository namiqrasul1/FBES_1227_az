using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace TodoWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;

        public TestController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        [HttpGet("test")]
        public async Task<IActionResult> Get()
        {
            var userId = "user42";

            if (_memoryCache.TryGetValue<string>($"orders_{userId}", out var cachedData))
                return Ok(cachedData);
            else
            {
                await Task.Delay(3000);
                var data = "It works"; // db or some algorithm 

                _memoryCache.Set(
                    key: $"orders_{userId}",
                    value: data,
                    options: new MemoryCacheEntryOptions { AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(30) });

                return Ok(data);
            }
        }
    }
}
