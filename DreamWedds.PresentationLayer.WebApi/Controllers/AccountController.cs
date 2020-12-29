using System;
using System.Security.Claims;
using System.Threading.Tasks;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.PresentationLayer.WebApi.Filters;
using DreamWedds.PresentationLayer.WebApi.Model;
using IdentityServer4.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DreamWedds.PresentationLayer.WebApi.ApiControllers
{
    [Route("api")]
    public class AccountController : ControllerBase
    {
        private readonly ITokenClaimsService _tokenClaimsService;
        private IUserService _userBusinessInstance;
        private IConfiguration _config;
        private ILogger _logger;

        public AccountController(IUserService userBusinessInstance,
            ILogger<AccountController> logger,
            ITokenClaimsService tokenClaimsService,
            IConfiguration config)
        {
            _tokenClaimsService = tokenClaimsService;
            _userBusinessInstance = userBusinessInstance;
            _logger = logger;
            _config = config;
        }

        [HttpPost("token")]
        public async Task<ActionResult<AuthenticateResponse>> HandleAsync([FromBody] LoginRequest request)
        {
            var response = new AuthenticateResponse(request.CorrelationId());
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _userBusinessInstance.AuthenticateUser(request.Username, request.Password);
                    if (result == null)
                    {
                        return Unauthorized();
                    }
                    response.IsSuccess = true;
                    response.ExpiresIn = int.Parse(_config.GetSection("Tokens").GetSection("Lifetime").Value);

                    response.Token = await _tokenClaimsService.GetToken(result.Id);
                    return response;
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }

            }
            return BadRequest(ModelState);

        }

        [HttpGet]
        public async Task<ActionResult<ApplicationUser>> Get(int id)
        {
            if (id == 0) return BadRequest();
            return await _userBusinessInstance.GetUserAsync(id);
        }

        [HttpGet("user/{UserId}")]
        [Authorize]
        public async Task<ActionResult> GetUserByID(int UserId)
        {
            if (UserId == 0) return BadRequest();

            var userId =  User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);

            ApplicationUser item = await _userBusinessInstance.GetUserAsync(UserId);
            if (item is null) return NotFound();

            return Ok(item);
        }
    }
}
