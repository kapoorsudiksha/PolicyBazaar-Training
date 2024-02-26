using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace coreWebAPIWithMiddlewareProject.Controllers
{
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [Produces("text/plain")]
        [HttpGet("demo1")]
        public async Task<IActionResult> Demo1()
        {
            try
            {
                var content = "Hello World";
                return Ok(content);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Produces("text/html")]
        [HttpGet("demo2")]
        public async Task<IActionResult> Demo2()
        {
            try
            {
                var content = "<b><u>Hello World<b><u>";
                return new ContentResult
                {
                    Content = content,
                    ContentType = "text/html",
                    StatusCode = (int)HttpStatusCode.OK
                };
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
