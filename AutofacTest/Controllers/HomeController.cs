using AutofacTest.Data;
using AutofacTest.Data.Entities;
using AutofacTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ILogger = AutofacTest.Services.ILogger;

namespace AutofacTest.Controllers
{
    [Route("api/Home")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Test()
        {
            var user = new User
            {
                UserName = "newUser51",
                Email = "newUser51@gmail.com"
            };
            var result = _userService.Add(user);
            return Ok(result);
        }
    }
}
