using DreamWedds.CommonLayer.Application.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace DreamWedds.PresentationLayer.WebApi.Filters
{
    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    //public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    //{
    //    public void OnAuthorization(AuthorizationFilterContext context)
    //    {
    //        var user = (ApplicationUser)context.HttpContext.Items["User"];
    //        if (user == null)
    //        {
    //            context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
    //        }
    //    }
    //}
}
