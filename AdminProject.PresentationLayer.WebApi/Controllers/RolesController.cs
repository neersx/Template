using System.Threading.Tasks;
using DreamWedds.CommonLayer.Application.DTO;
using DreamWedds.CommonLayer.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AdminProject.PresentationLayer.WebApi.Controllers
{
    [Route("api/role")]
    [Authorize(Roles = "Admin")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IUserService _userBusinessInstance;

        public RolesController(IUserService userBusinessInstance, ILogger<RolesController> logger)
        {
            _userBusinessInstance = userBusinessInstance;
            logger.LogDebug(1, "Logger injected into RolesController");
        }

        [HttpGet]
        public async Task<ActionResult<UserMasterDto>> Get(int id)
        {
            if (id == 0) return BadRequest();
            return await _userBusinessInstance.GetUserAsync(id);
        }

        [HttpPost("user/assign-role")]
        public async Task<ActionResult> AssignRoleToUser([FromBody] UserRolesDto roles)
        {
            if (roles == null) return BadRequest();

            var id = await _userBusinessInstance.AssignRoleToUser(roles);
            return Ok(id);
        }

        [HttpGet("user/remove-role/{userId}")]
        public async Task<ActionResult> RemoveRoleFromUser(int userId)
        {
            if (userId == 0) return BadRequest();

            await _userBusinessInstance.RevokeRoleFromUser(userId);
            return Ok();
        }

        [HttpGet("all-roles")]
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

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult> GetRoleById(int id)
        {
            if (id == 0) return BadRequest();

            var item = await _userBusinessInstance.GetRoleByIdAsync(id);
            if (item is null) return NotFound();

            return Ok(item);
        }

        [HttpPost("add")]
        [Authorize]
        public async Task<ActionResult> AddNewRole([FromBody] RoleMasterDto role)
        {
            if (role == null) return BadRequest();

            var id = await _userBusinessInstance.AddNewRoleAsync(role);
            return Ok(id);
        }

        [HttpPut("update")]
        [Authorize]
        public async Task<ActionResult> UpdateExistingRole([FromBody] RoleMasterDto role)
        {
            if (role == null) return BadRequest();

            await _userBusinessInstance.UpdateRoleAsync(role);
            return Ok();
        }
    }
}