using System;
using System.Threading.Tasks;
using AdminProject.PresentationLayer.WebApi.Model;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.CommonLayer.Aspects.Utitlities;
using DreamWedds.CommonLayer.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AdminProject.PresentationLayer.WebApi.Controllers
{
    [Route("api")]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IEmailService _emailService;
        private readonly ISecurityService _securityBusinessInstance;
        private readonly ITokenClaimsService _tokenClaimsService;
        private readonly IUserService _userBusinessInstance;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IUserService userBusinessInstance,
            ITokenClaimsService tokenClaimsService,
            IConfiguration config,
            IEmailService emailService, 
            ISecurityService securityBusinessInstance, ILogger<AccountController> logger)
        {
            _tokenClaimsService = tokenClaimsService;
            _userBusinessInstance = userBusinessInstance;
            _config = config;
            _emailService = emailService;
            _securityBusinessInstance = securityBusinessInstance;
            _logger = logger;
            _logger.LogDebug(1, "Logger injected into AccountsController");
        }

        [HttpPost("token")]
        [AllowAnonymous]
        public async Task<ActionResult<AuthenticateResponse>> Authenticate([FromBody] LoginRequest request)
        {
            _logger.LogInformation("Authenticate user details.");
            var response = new AuthenticateResponse(request.CorrelationId());
            if (ModelState.IsValid)
                try
                {
                    var result = await _userBusinessInstance.AuthenticateUser(request.Username, request.Password);
                    if (result == null) return Unauthorized();
                    response.IsSuccess = true;
                    response.ExpiresIn = int.Parse(_config.GetSection("Tokens").GetSection("Lifetime").Value);

                    response.Token = await _tokenClaimsService.GetToken(result.Id);
                    return response;
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }

            return BadRequest(ModelState);
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult> RegisterUser([FromBody] UserMasterDto user)
        {
            if (user == null) return BadRequest();
            try
            {
                var id = await _userBusinessInstance.AddNewUserAsync(user);
                return Ok(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        [HttpPost("forget-password")]
        public async Task<ActionResult<JsonResponse<UserMasterDto>>> ForgetPasswordNotification([FromBody] LoginModel model)
        {
            var response = new JsonResponse<UserMasterDto>();
            if (string.IsNullOrEmpty(model.Email))
                return BadRequest();
            try
            {
                var user = await _userBusinessInstance.GetUserByEmailAsync(model);
                if (user == null) return response;

                var uniqueString = await _securityBusinessInstance.GetOtpAsync(user.Id);
                if (string.IsNullOrEmpty(uniqueString)) return response;

                await _emailService.PrepareAndSendEmailAsync(user, uniqueString, AspectEnums.TemplateType.ResetPassword, null);
                response.IsSuccess = true;
                response.SingleResult = user;
                response.StatusCode = 200;
                response.Message = "Please check your registered email for rest password link.";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                response.StatusCode = 500;
                response.IsSuccess = false;
                response.Message = "Error occured: " + e.Message;
            }

            return response;
        }

        [HttpGet]
        [Route("validate-reset-url/{id}")]
        public async Task<JsonResponse<UserMasterDto>> ValidatePasswordResetUrl(string id)
        {
            var response = new JsonResponse<UserMasterDto>();
            try
            {
                var isValid = await _securityBusinessInstance.ValidateGuidAsync(id);
                if (isValid)
                {
                    response.SingleResult = await _userBusinessInstance.GetUserByGuidAsync(id);
                    response.IsSuccess = true;
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "Password reset link is expired or invalid. Try again later.";
                }

                response.StatusCode = 200;
            }
            catch (Exception ex)
            {
                response.SingleResult = null;
                response.StatusCode = 500;
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        [HttpPost]
        [Route("reset-password")]
        public async Task<JsonResponse<bool>> ChangeUserPassword(LoginModel model)
        {
            var response = new JsonResponse<bool>();
            try
            {
                var User = await _userBusinessInstance.GetUserByEmailAsync(model);
                if (User == null)
                {
                    response.SingleResult = false;
                    response.StatusCode = 200;
                    response.IsSuccess = false;
                    response.Message = "User does not exist in our system.";
                    return response;
                }

                if (User.Password != model.Password)
                {
                    User.Password = model.Password;

                    response.SingleResult = await _userBusinessInstance.ChangePasswordAsync(model.Guid, model.Password);
                    response.IsSuccess = response.SingleResult;
                    response.StatusCode = 200;
                    response.Message = "Your password has been successfully updated.";
                }
                else
                {
                    response.SingleResult = false;
                    response.StatusCode = 200;
                    response.IsSuccess = false;
                    response.Message = "You can not use same password. it must be different than previous.";
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.StatusCode = 500;
                response.Message = ex.Message;
            }

            return response;
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<UserMasterDto>> Get(int id)
        {
            if (id == 0) return BadRequest();
            return await _userBusinessInstance.GetUserAsync(id);
        }

        [HttpGet("user/{UserId}")]
        [Authorize]
        public async Task<ActionResult> GetUserById(int userId)
        {
            if (userId == 0) return BadRequest();

            var item = await _userBusinessInstance.GetUserAsync(userId);
            if (item is null) return NotFound();

            return Ok(item);
        }

        [HttpPost("user/add")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> AddNewUser([FromBody] UserMasterDto user)
        {
            if (user == null) return BadRequest();
            try
            {
                var id = await _userBusinessInstance.AddNewUserAsync(user);
                return Ok(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut("user/update")]
        [Authorize]
        public async Task<ActionResult> UpdateExistingUser([FromBody] UserMasterDto user)
        {
            if (user == null) return BadRequest();
            try
            {
                await _userBusinessInstance.UpdateUserAsync(user);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("user/remove/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> RemoveExistingUser(int id)
        {
            if (id == 0) return BadRequest();
            try
            {
                await _userBusinessInstance.RemoveUserAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost("user/assign-role")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> AssignRoleToUser([FromBody] UserRolesDto roles)
        {
            if (roles == null) return BadRequest();
            try
            {
                var id = await _userBusinessInstance.AssignRoleToUser(roles);
                return Ok(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("user/remove-role/{userId}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> RemoveRoleFromUser(int userId)
        {
            if (userId == 0) return BadRequest();
            try
            {
                await _userBusinessInstance.RevokeRoleFromUser(userId);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("roles")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> GetRoles()
        {
            var item = await _userBusinessInstance.GetAllRolesAsync();
            if (item is null) return NotFound();

            return Ok(item);
        }

        [HttpGet("user-roles/{userId}")]
        [Authorize]
        public async Task<ActionResult> GetUserRoles(int userId)
        {
            var item = await _userBusinessInstance.GetUserRolesAsync(userId);
            if (item is null) return NotFound();

            return Ok(item);
        }

        [HttpGet("role/{id}")]
        [Authorize]
        public async Task<ActionResult> GetRoleById(int id)
        {
            if (id == 0) return BadRequest();

            var item = await _userBusinessInstance.GetRoleByIdAsync(id);
            if (item is null) return NotFound();

            return Ok(item);
        }

        [HttpPost("role/add")]
        [Authorize]
        public async Task<ActionResult> AddNewRole([FromBody] RoleMasterDto role)
        {
            if (role == null) return BadRequest();
            try
            {
                var id = await _userBusinessInstance.AddNewRoleAsync(role);
                return Ok(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut("role/update")]
        [Authorize]
        public async Task<ActionResult> UpdateExistingRole([FromBody] RoleMasterDto role)
        {
            if (role == null) return BadRequest();
            try
            {
                await _userBusinessInstance.UpdateRoleAsync(role);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}