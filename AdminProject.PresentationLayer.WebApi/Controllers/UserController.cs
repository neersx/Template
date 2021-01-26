using System;
using System.Threading.Tasks;
using AdminProject.PresentationLayer.WebApi.Helpers;
using AdminProject.CommonLayer.Application.DTO;
using AdminProject.CommonLayer.Application.Interfaces;
using AdminProject.CommonLayer.Aspects.Extensions;
using AdminProject.CommonLayer.Aspects.Models;
using AdminProject.CommonLayer.Infrastructure;
using AdminProject.CommonLayer.Infrastructure.Extensions;
using AdminProject.CommonLayer.Infrastructure.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AuthorizeAttribute = Microsoft.AspNetCore.Authorization.AuthorizeAttribute;

namespace AdminProject.PresentationLayer.WebApi.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/user")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userBusinessInstance;
        private readonly ILogger<UserController> _logger;
        readonly ICommonQueryService _commonQueryService;

        public UserController(ILogger<UserController> logger, IUserService userBusinessInstance, ICommonQueryService commonQueryService)
        {
            _userBusinessInstance = userBusinessInstance;
            _logger = logger;
            _commonQueryService = commonQueryService ?? throw new ArgumentNullException("commonQueryService");
        }


        [HttpGet]
        //[RequiresAccessTo(ApplicationTask.AllowedAccessAlways)]
        //[Authorize(Policy = "TaskSecurity")]
        [Route("all-users")]
        public async Task<ActionResult<PagedResults>> GetAllUsers([ModelBinder(BinderType = typeof(JsonQueryBinder), Name = "params")] CommonQueryParameters qp = null)
        {
            var queryParameters = qp ?? new CommonQueryParameters();
            var userId = User.GetLoggedInUserId<string>();
            var user = await _userBusinessInstance.GetAllUsers();
            var r = _commonQueryService.Filter(user, queryParameters).AsPagedResults(queryParameters);
            if (user == null) throw new AppException("No User found for: " + userId);
            var result = new PagedResults(r.Data, r.Pagination.Total);
            return Ok(result);
        }

        [HttpGet("{UserId}")]
        public async Task<ActionResult> GetUserById(int userId)
        {
            if (userId == 0) return BadRequest();

            var item = await _userBusinessInstance.GetUserAsync(userId);
            if (item is null) return NotFound();

            return Ok(item);
        }

        [HttpPost("add")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> AddNewUser([FromBody] UserMasterDto user)
        {
            if (user == null) return BadRequest();
            var userExists = await _userBusinessInstance.IsUserAlreadyExists(user.Email);
            if (userExists) throw new AppException("User with email address: " + user.Email + " already registered with us. Please follow the email we sent now.");

            var id = await _userBusinessInstance.AddNewUserAsync(user);
            return Ok(id);
        }

        [HttpPut("update")]
        public async Task<ActionResult> UpdateExistingUser([FromBody] UserMasterDto user)
        {
            if (user == null) return BadRequest();

            await _userBusinessInstance.UpdateUserAsync(user);
            return Ok();

        }

        [HttpGet("remove/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> RemoveExistingUser(int id)
        {
            if (id == 0) return BadRequest();

            await _userBusinessInstance.RemoveUserAsync(id);
            return Ok();
        }
    }
}
