using System;
using System.Threading.Tasks;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.CommonLayer.Aspects.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AuthorizeAttribute = Microsoft.AspNetCore.Authorization.AuthorizeAttribute;

namespace AdminProject.PresentationLayer.WebApi.Controllers
{
    [ApiController]   
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IUserService _userBusinessInstance;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IUserService userBusinessInstance)
        {
            _userBusinessInstance = userBusinessInstance;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.Log(LogLevel.Debug, "Hello Debugger!");
            try
            {
                var user = Summaries;
                if (user != null)
                {
                    return Ok(user);
                }

                return NotFound("No User found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet]
        [Authorize]
        [Route("users")]
        public async Task<IActionResult> GetAllusers()
        {
            _logger.Log(LogLevel.Debug, "Hello Debugger!");
            var userId = User.GetLoggedInUserId<string>();
            try
            {
                var user = await _userBusinessInstance.GetAllUsers();
                if (user != null)
                {
                    return Ok(user);
                }

                return NotFound("No User found for: " + userId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
