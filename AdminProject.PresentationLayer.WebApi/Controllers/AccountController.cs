using System;
using System.Threading.Tasks;
using AdminProject.PresentationLayer.WebApi.Model;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using DreamWedds.CommonLayer.Aspects.Utitlities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AdminProject.PresentationLayer.WebApi.Controllers
{
    [Route("api")]
    public class AccountController : ControllerBase
    {
        private readonly ITokenClaimsService _tokenClaimsService;
        private readonly IUserService _userBusinessInstance;
        private readonly IConfiguration _config;

        public AccountController(IUserService userBusinessInstance,
            ITokenClaimsService tokenClaimsService,
            IConfiguration config)
        {
            _tokenClaimsService = tokenClaimsService;
            _userBusinessInstance = userBusinessInstance;
            _config = config;
        }

        [HttpPost("token")]
        [AllowAnonymous]
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
        [Authorize]
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

            UserMasterDto item = await _userBusinessInstance.GetUserAsync(userId);
            if (item is null) return NotFound();

            return Ok(item);
        }

        [HttpPost("user/add")]
        [Authorize]
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
        [Authorize]
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
        [Authorize]
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
        [Authorize]
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
        [Authorize]
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
