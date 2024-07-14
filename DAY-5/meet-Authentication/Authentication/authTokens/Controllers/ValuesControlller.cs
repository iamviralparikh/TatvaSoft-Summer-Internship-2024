using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Admin")]
        [Route("admin")]
        public IActionResult AdminEndpoint()
        {
            return Ok("Welcome back!! Admin");
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        [Route("user")]
        public IActionResult UserEndpoint()
        {
            return Ok("Welcome back!! User");
        }

        [HttpGet]
        [Authorize]
        [Route("all")]
        public IActionResult AllEndpoint()
        {
            return Ok("Hello Authenticated User");
        }
    }
}

